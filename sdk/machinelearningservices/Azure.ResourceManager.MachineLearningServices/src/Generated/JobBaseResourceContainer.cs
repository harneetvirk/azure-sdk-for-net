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
    /// <summary> A class representing collection of JobBaseResource and their operations over a Workspace. </summary>
    public partial class JobBaseResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, JobBaseResource, JobBaseResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="JobBaseResourceContainer"/> class for mocking. </summary>
        protected JobBaseResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of JobBaseResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JobBaseResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = ManagementPipelineBuilder.Build(Credential, BaseUri, ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;

        /// <summary> Represents the REST operations. </summary>
        private JobsRestOperations _restClient => new JobsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a JobBaseResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public Response<JobBaseResource> CreateOrUpdate(string workspaceName, JobBase properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                return StartCreateOrUpdate(workspaceName, properties, cancellationToken: cancellationToken).WaitForCompletion();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a JobBaseResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<Response<JobBaseResource>> CreateOrUpdateAsync(string workspaceName, JobBase properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var operation = await StartCreateOrUpdateAsync(workspaceName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a JobBaseResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public JobsCreateOrUpdateOperation StartCreateOrUpdate(string workspaceName, JobBase properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.Name, Id.ResourceGroupName, workspaceName, properties, cancellationToken: cancellationToken);
                return new JobsCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a JobBaseResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<JobsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string workspaceName, JobBase properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.Name, Id.ResourceGroupName, workspaceName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new JobsCreateOrUpdateOperation(Parent, originalResponse);
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
        public override Response<JobBaseResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = _restClient.Get(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(new JobBaseResource(Parent, response.Value), response.GetRawResponse());
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
        public async override Task<Response<JobBaseResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = await _restClient.GetAsync(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JobBaseResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="JobBaseResource" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="JobBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<JobBaseResource> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<JobBaseResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobBaseResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="JobBaseResource" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="JobBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<JobBaseResource> List(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResource(null, top, cancellationToken);
            return new PhWrappingPageable<GenericResource, JobBaseResource>(results, genericResource => new JobBaseResourceOperations(genericResource, genericResource.Id as ResourceGroupResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of <see cref="JobBaseResource" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="JobBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<JobBaseResource> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<JobBaseResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobBaseResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="JobBaseResource" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="JobBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<JobBaseResource> ListAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResourceAsync(null, top, cancellationToken);
            return new PhWrappingAsyncPageable<GenericResource, JobBaseResource>(results, genericResource => new JobBaseResourceOperations(genericResource, genericResource.Id as ResourceGroupResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of JobBaseResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(JobBaseResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of JobBaseResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobBaseResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(JobBaseResourceOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, JobBaseResource, JobBaseResourceData> Construct() { }
    }
}
