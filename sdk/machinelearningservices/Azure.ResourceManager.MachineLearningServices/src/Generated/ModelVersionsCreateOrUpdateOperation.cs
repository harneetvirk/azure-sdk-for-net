// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Create or update version. </summary>
    public partial class ModelVersionsCreateOrUpdateOperation : Operation<ModelVersionResource>
    {
        private readonly OperationOrResponseInternals<ModelVersionResource> _operation;

        /// <summary> Initializes a new instance of ModelVersionsCreateOrUpdateOperation for mocking. </summary>
        protected ModelVersionsCreateOrUpdateOperation()
        {
        }

        internal ModelVersionsCreateOrUpdateOperation(ResourceOperationsBase operationsBase, Response<ModelVersionResourceData> response)
        {
            _operation = new OperationOrResponseInternals<ModelVersionResource>(Response.FromValue(new ModelVersionResource(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ModelVersionResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ModelVersionResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ModelVersionResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
