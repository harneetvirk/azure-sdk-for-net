// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Creates or updates a linked service. </summary>
    public partial class LinkedServiceCreateOrUpdateLinkedServiceOperation : Operation<LinkedServiceResource>, IOperationSource<LinkedServiceResource>
    {
        private readonly ArmOperationHelpers<LinkedServiceResource> _operation;

        /// <summary> Initializes a new instance of LinkedServiceCreateOrUpdateLinkedServiceOperation for mocking. </summary>
        protected LinkedServiceCreateOrUpdateLinkedServiceOperation()
        {
        }

        internal LinkedServiceCreateOrUpdateLinkedServiceOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<LinkedServiceResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "LinkedServiceCreateOrUpdateLinkedServiceOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LinkedServiceResource Value => _operation.Value;

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
        public override ValueTask<Response<LinkedServiceResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LinkedServiceResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LinkedServiceResource IOperationSource<LinkedServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LinkedServiceResource.DeserializeLinkedServiceResource(document.RootElement);
        }

        async ValueTask<LinkedServiceResource> IOperationSource<LinkedServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LinkedServiceResource.DeserializeLinkedServiceResource(document.RootElement);
        }
    }
}
