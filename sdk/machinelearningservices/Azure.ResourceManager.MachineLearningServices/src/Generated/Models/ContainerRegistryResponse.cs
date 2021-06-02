// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ContainerRegistryResponse. </summary>
    public partial class ContainerRegistryResponse
    {
        /// <summary> Initializes a new instance of ContainerRegistryResponse. </summary>
        public ContainerRegistryResponse()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryResponse. </summary>
        /// <param name="address"> . </param>
        internal ContainerRegistryResponse(string address)
        {
            Address = address;
        }

        public string Address { get; set; }
    }
}
