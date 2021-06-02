// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A system service running on a compute. </summary>
    public partial class SystemService
    {
        /// <summary> Initializes a new instance of SystemService. </summary>
        internal SystemService()
        {
        }

        /// <summary> Initializes a new instance of SystemService. </summary>
        /// <param name="systemServiceType"> The type of this system service. </param>
        /// <param name="publicIpAddress"> Public IP address. </param>
        /// <param name="version"> The version for this type. </param>
        internal SystemService(string systemServiceType, string publicIpAddress, string version)
        {
            SystemServiceType = systemServiceType;
            PublicIpAddress = publicIpAddress;
            Version = version;
        }

        /// <summary> The type of this system service. </summary>
        public string SystemServiceType { get; }
        /// <summary> Public IP address. </summary>
        public string PublicIpAddress { get; }
        /// <summary> The version for this type. </summary>
        public string Version { get; }
    }
}
