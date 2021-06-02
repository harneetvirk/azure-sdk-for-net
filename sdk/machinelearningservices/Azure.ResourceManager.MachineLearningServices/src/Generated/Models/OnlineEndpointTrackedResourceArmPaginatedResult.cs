// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A paginated list of OnlineEndpoint entities. </summary>
    internal partial class OnlineEndpointTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceArmPaginatedResult. </summary>
        internal OnlineEndpointTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<OnlineEndpointTrackedResourceData>();
        }

        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceArmPaginatedResult. </summary>
        /// <param name="value"> An array of objects of type OnlineEndpoint. </param>
        /// <param name="nextLink"> . </param>
        internal OnlineEndpointTrackedResourceArmPaginatedResult(IReadOnlyList<OnlineEndpointTrackedResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of objects of type OnlineEndpoint. </summary>
        public IReadOnlyList<OnlineEndpointTrackedResourceData> Value { get; }
        public string NextLink { get; }
    }
}
