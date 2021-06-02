// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> User assigned identities associated with a resource. </summary>
    public partial class UserAssignedIdentityMeta
    {
        /// <summary> Initializes a new instance of UserAssignedIdentityMeta. </summary>
        public UserAssignedIdentityMeta()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentityMeta. </summary>
        /// <param name="principalId"> The object ID of the service principal object for your managed identity that is used to grant role-based access to an Azure resource. </param>
        /// <param name="clientId"> Aka application ID, a unique identifier generated by Azure AD that is tied to an application and service principal during its initial provisioning. </param>
        internal UserAssignedIdentityMeta(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The object ID of the service principal object for your managed identity that is used to grant role-based access to an Azure resource. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Aka application ID, a unique identifier generated by Azure AD that is tied to an application and service principal during its initial provisioning. </summary>
        public string ClientId { get; set; }
    }
}
