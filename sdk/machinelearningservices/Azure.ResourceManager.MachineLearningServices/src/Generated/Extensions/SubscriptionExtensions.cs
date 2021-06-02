// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region Workspace
        private static WorkspacesRestOperations GetWorkspacesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, string subscriptionId, Uri endpoint = null)
        {
            var httpPipeline = ManagementPipelineBuilder.Build(credential, endpoint, clientOptions);
            return new WorkspacesRestOperations(clientDiagnostics, httpPipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the Workspaces for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Workspace> ListWorkspaceAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResources((baseUri, credential, options) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetWorkspacesRestOperations(clientDiagnostics, credential, options, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscriptionAsync(clientDiagnostics, restOperations);
                return new PhWrappingAsyncPageable<WorkspaceData, Workspace>(
                result,
                s => new Workspace(subscription, s));
            }
            );
        }

        /// <summary> Lists all the available machine learning workspaces under the specified subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static AsyncPageable<WorkspaceData> ListBySubscriptionAsync(ClientDiagnostics clientDiagnostics, WorkspacesRestOperations restOperations, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkspaceData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("WorkspaceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionAsync(skip, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkspaceData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("WorkspaceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, skip, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the Workspaces for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Workspace> ListWorkspace(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResources((baseUri, credential, options) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetWorkspacesRestOperations(clientDiagnostics, credential, options, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscription(clientDiagnostics, restOperations);
                return new PhWrappingPageable<WorkspaceData, Workspace>(
                result,
                s => new Workspace(subscription, s));
            }
            );
        }

        /// <summary> Lists all the available machine learning workspaces under the specified subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static Pageable<WorkspaceData> ListBySubscription(ClientDiagnostics clientDiagnostics, WorkspacesRestOperations restOperations, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<WorkspaceData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("WorkspaceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscription(skip, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkspaceData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("WorkspaceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscriptionNextPage(nextLink, skip, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of Workspaces for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<GenericResource> ListWorkspaceByNameAsync(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(WorkspaceOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, top, cancellationToken);
        }

        /// <summary> Filters the list of Workspaces for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<GenericResource> ListWorkspaceByName(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(WorkspaceOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, top, cancellationToken);
        }
        #endregion
    }
}
