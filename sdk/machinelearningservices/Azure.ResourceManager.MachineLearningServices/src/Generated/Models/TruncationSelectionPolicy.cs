// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Defines an early termination policy that cancels a given percentage of runs at each evaluation interval. </summary>
    public partial class TruncationSelectionPolicy : EarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of TruncationSelectionPolicy. </summary>
        public TruncationSelectionPolicy()
        {
            PolicyType = EarlyTerminationPolicyType.TruncationSelection;
        }

        /// <summary> Initializes a new instance of TruncationSelectionPolicy. </summary>
        /// <param name="policyType"> Name of policy configuration. </param>
        /// <param name="evaluationInterval"> . </param>
        /// <param name="delayEvaluation"> . </param>
        /// <param name="truncationPercentage"> . </param>
        internal TruncationSelectionPolicy(EarlyTerminationPolicyType policyType, int? evaluationInterval, int? delayEvaluation, int? truncationPercentage) : base(policyType, evaluationInterval, delayEvaluation)
        {
            TruncationPercentage = truncationPercentage;
            PolicyType = policyType;
        }

        public int? TruncationPercentage { get; set; }
    }
}
