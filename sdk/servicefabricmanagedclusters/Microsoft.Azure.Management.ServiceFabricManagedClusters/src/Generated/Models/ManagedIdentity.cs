// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the managed identities for an Azure resource.
    /// </summary>
    public partial class ManagedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentity class.
        /// </summary>
        public ManagedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentity class.
        /// </summary>
        /// <param name="principalId">The principal id of the managed identity.
        /// This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="tenantId">The tenant id of the managed identity. This
        /// property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="type">Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned'</param>
        public ManagedIdentity(string principalId = default(string), string tenantId = default(string), ManagedIdentityType? type = default(ManagedIdentityType?), IDictionary<string, UserAssignedIdentity> userAssignedIdentities = default(IDictionary<string, UserAssignedIdentity>))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of the managed identity. This property will
        /// only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id of the managed identity. This property will only
        /// be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'SystemAssigned',
        /// 'UserAssigned', 'SystemAssigned, UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ManagedIdentityType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; set; }

    }
}
