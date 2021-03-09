﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// A class representing the operations that can be performed over a specific resource.
    /// </summary>
    public abstract class OperationsBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsBase"/> class.
        /// </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseUri"> The base URI of the service. </param>
        protected OperationsBase(AzureResourceManagerClientOptions options, NewResourceIdentifier id, TokenCredential credential, Uri baseUri)
        {
            ClientOptions = options;
            GenericId = id;
            Credential = credential;
            BaseUri = baseUri;
            Validate(id);
        }

        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        internal virtual NewResourceIdentifier GenericId { get; }

        /// <summary>
        /// Gets the Azure Resource Manager client options.
        /// </summary>
        public virtual AzureResourceManagerClientOptions ClientOptions { get; }

        /// <summary>
        /// Gets the Azure credential.
        /// </summary>
        public TokenCredential Credential { get; }

        /// <summary>
        /// Gets the base URI of the service.
        /// </summary>
        public Uri BaseUri { get; }

        /// <summary>
        /// Gets the valid Azure resource type for the current operations.
        /// </summary>
        /// <returns> A valid Azure resource type. </returns>
        protected abstract ResourceType ValidResourceType { get; }

        /// <summary>
        /// Gets the resource client.
        /// </summary>
        protected ResourcesManagementClient ResourcesClient
        {
            get
            {
                string subscription;
                if (!Id.TryGetSubscriptionId(out subscription))
                {
                    throw new InvalidOperationException("Subscription is not available.");
                }

                return new ResourcesManagementClient(BaseUri, subscription, Credential);
            }
        }

        /// <summary>
        /// Validate the resource identifier against current operations.
        /// </summary>
        /// <param name="identifier"> The resource identifier. </param>
        protected virtual void Validate(NewResourceIdentifier identifier)
        {
            if (identifier?.ResourceType != ValidResourceType)
                throw new ArgumentException($"Invalid resource type {identifier?.ResourceType} expected {ValidResourceType}");
        }
    }
}
