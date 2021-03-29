// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceProvisioningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The available private link resources for a provisioning service
    /// </summary>
    public partial class PrivateLinkResources
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResources class.
        /// </summary>
        public PrivateLinkResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResources class.
        /// </summary>
        /// <param name="value">The list of available private link resources
        /// for a provisioning service</param>
        public PrivateLinkResources(IList<GroupIdInformation> value = default(IList<GroupIdInformation>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of available private link resources for a
        /// provisioning service
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GroupIdInformation> Value { get; set; }

    }
}
