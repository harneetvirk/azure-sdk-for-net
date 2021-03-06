// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Details of a REST API operation, returned from the Resource Provider Operations API. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="name"> The name of the operation, as per Resource-Based Access Control (RBAC). Examples: &quot;Microsoft.Compute/virtualMachines/write&quot;, &quot;Microsoft.Compute/virtualMachines/capture/action&quot;. </param>
        /// <param name="isDataAction"> Whether the operation applies to data-plane. This is &quot;true&quot; for data-plane operations and &quot;false&quot; for ARM/control-plane operations. </param>
        /// <param name="display"> Localized display information for this particular operation. </param>
        /// <param name="origin"> The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is &quot;user,system&quot;. </param>
        /// <param name="actionType"> Enum. Indicates the action type. &quot;Internal&quot; refers to actions that are for internal only APIs. </param>
        internal Operation(string name, bool? isDataAction, OperationDisplay display, Origin? origin, ActionType? actionType)
        {
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            Origin = origin;
            ActionType = actionType;
        }

        /// <summary> The name of the operation, as per Resource-Based Access Control (RBAC). Examples: &quot;Microsoft.Compute/virtualMachines/write&quot;, &quot;Microsoft.Compute/virtualMachines/capture/action&quot;. </summary>
        public string Name { get; }
        /// <summary> Whether the operation applies to data-plane. This is &quot;true&quot; for data-plane operations and &quot;false&quot; for ARM/control-plane operations. </summary>
        public bool? IsDataAction { get; }
        /// <summary> Localized display information for this particular operation. </summary>
        public OperationDisplay Display { get; }
        /// <summary> The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is &quot;user,system&quot;. </summary>
        public Origin? Origin { get; }
        /// <summary> Enum. Indicates the action type. &quot;Internal&quot; refers to actions that are for internal only APIs. </summary>
        public ActionType? ActionType { get; }
    }
}
