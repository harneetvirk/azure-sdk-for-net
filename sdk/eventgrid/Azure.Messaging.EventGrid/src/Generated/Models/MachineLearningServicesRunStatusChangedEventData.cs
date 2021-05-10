// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.MachineLearningServices.RunStatusChanged event. </summary>
    public partial class MachineLearningServicesRunStatusChangedEventData
    {
        /// <summary> Initializes a new instance of MachineLearningServicesRunStatusChangedEventData. </summary>
        internal MachineLearningServicesRunStatusChangedEventData()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningServicesRunStatusChangedEventData. </summary>
        /// <param name="experimentId"> The ID of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="experimentName"> The name of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="runId"> The ID of the Machine Learning Run. </param>
        /// <param name="runType"> The Run Type of the Machine Learning Run. </param>
        /// <param name="runTags"> The tags of the Machine Learning Run. </param>
        /// <param name="runProperties"> The properties of the Machine Learning Run. </param>
        /// <param name="runStatus"> The status of the Machine Learning Run. </param>
        internal MachineLearningServicesRunStatusChangedEventData(string experimentId, string experimentName, string runId, string runType, object runTags, object runProperties, string runStatus)
        {
            ExperimentId = experimentId;
            ExperimentName = experimentName;
            RunId = runId;
            RunType = runType;
            RunTags = runTags;
            RunProperties = runProperties;
            RunStatus = runStatus;
        }

        /// <summary> The ID of the experiment that the Machine Learning Run belongs to. </summary>
        public string ExperimentId { get; }
        /// <summary> The name of the experiment that the Machine Learning Run belongs to. </summary>
        public string ExperimentName { get; }
        /// <summary> The ID of the Machine Learning Run. </summary>
        public string RunId { get; }
        /// <summary> The Run Type of the Machine Learning Run. </summary>
        public string RunType { get; }
        /// <summary> The tags of the Machine Learning Run. </summary>
        public object RunTags { get; }
        /// <summary> The properties of the Machine Learning Run. </summary>
        public object RunProperties { get; }
        /// <summary> The status of the Machine Learning Run. </summary>
        public string RunStatus { get; }
    }
}
