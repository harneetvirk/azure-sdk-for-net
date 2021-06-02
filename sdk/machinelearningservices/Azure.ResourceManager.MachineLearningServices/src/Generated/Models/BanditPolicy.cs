// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Defines an early termination policy based on slack criteria, and a frequency and delay interval for evaluation. </summary>
    public partial class BanditPolicy : EarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of BanditPolicy. </summary>
        public BanditPolicy()
        {
            PolicyType = EarlyTerminationPolicyType.Bandit;
        }

        /// <summary> Initializes a new instance of BanditPolicy. </summary>
        /// <param name="policyType"> Name of policy configuration. </param>
        /// <param name="evaluationInterval"> . </param>
        /// <param name="delayEvaluation"> . </param>
        /// <param name="slackFactor"> . </param>
        /// <param name="slackAmount"> . </param>
        internal BanditPolicy(EarlyTerminationPolicyType policyType, int? evaluationInterval, int? delayEvaluation, float? slackFactor, float? slackAmount) : base(policyType, evaluationInterval, delayEvaluation)
        {
            SlackFactor = slackFactor;
            SlackAmount = slackAmount;
            PolicyType = policyType;
        }

        public float? SlackFactor { get; set; }
        public float? SlackAmount { get; set; }
    }
}
