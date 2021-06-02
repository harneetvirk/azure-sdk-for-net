// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A paginated list of BatchDeployment entities. </summary>
    internal partial class BatchDeploymentTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceArmPaginatedResult. </summary>
        internal BatchDeploymentTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<BatchDeploymentTrackedResourceData>();
        }

        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceArmPaginatedResult. </summary>
        /// <param name="value"> An array of objects of type BatchDeployment. </param>
        /// <param name="nextLink"> . </param>
        internal BatchDeploymentTrackedResourceArmPaginatedResult(IReadOnlyList<BatchDeploymentTrackedResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of objects of type BatchDeployment. </summary>
        public IReadOnlyList<BatchDeploymentTrackedResourceData> Value { get; }
        public string NextLink { get; }
    }
}
