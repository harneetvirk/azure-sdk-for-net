// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of OnlineEndpointTrackedResource and their operations over a Workspace. </summary>
    public partial class OnlineEndpointTrackedResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, OnlineEndpointTrackedResource, OnlineEndpointTrackedResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointTrackedResourceContainer"/> class for mocking. </summary>
        protected OnlineEndpointTrackedResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OnlineEndpointTrackedResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = ManagementPipelineBuilder.Build(Credential, BaseUri, ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;

        /// <summary> Represents the REST operations. </summary>
        private OnlineEndpointsRestOperations _restClient => new OnlineEndpointsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public Response<OnlineEndpointTrackedResource> CreateOrUpdate(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                return StartCreateOrUpdate(workspaceName, body, cancellationToken: cancellationToken).WaitForCompletion();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<Response<OnlineEndpointTrackedResource>> CreateOrUpdateAsync(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var operation = await StartCreateOrUpdateAsync(workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public OnlineEndpointsCreateOrUpdateOperation StartCreateOrUpdate(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken);
                return new OnlineEndpointsCreateOrUpdateOperation(Parent, _clientDiagnostics, _pipeline, _restClient.CreateCreateOrUpdateRequest(Id.Name, Id.ResourceGroupName, workspaceName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<OnlineEndpointsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new OnlineEndpointsCreateOrUpdateOperation(Parent, _clientDiagnostics, _pipeline, _restClient.CreateCreateOrUpdateRequest(Id.Name, Id.ResourceGroupName, workspaceName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public override Response<OnlineEndpointTrackedResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = _restClient.Get(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async override Task<Response<OnlineEndpointTrackedResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = await _restClient.GetAsync(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OnlineEndpointTrackedResource" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<OnlineEndpointTrackedResource> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<OnlineEndpointTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OnlineEndpointTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OnlineEndpointTrackedResource" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<OnlineEndpointTrackedResource> List(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResource(null, top, cancellationToken);
            return new PhWrappingPageable<GenericResource, OnlineEndpointTrackedResource>(results, genericResource => new OnlineEndpointTrackedResourceOperations(genericResource, genericResource.Id as ResourceGroupResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of <see cref="OnlineEndpointTrackedResource" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<OnlineEndpointTrackedResource> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OnlineEndpointTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OnlineEndpointTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OnlineEndpointTrackedResource" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<OnlineEndpointTrackedResource> ListAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResourceAsync(null, top, cancellationToken);
            return new PhWrappingAsyncPageable<GenericResource, OnlineEndpointTrackedResource>(results, genericResource => new OnlineEndpointTrackedResourceOperations(genericResource, genericResource.Id as ResourceGroupResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of OnlineEndpointTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OnlineEndpointTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of OnlineEndpointTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OnlineEndpointTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, OnlineEndpointTrackedResource, OnlineEndpointTrackedResourceData> Construct() { }
    }
}
