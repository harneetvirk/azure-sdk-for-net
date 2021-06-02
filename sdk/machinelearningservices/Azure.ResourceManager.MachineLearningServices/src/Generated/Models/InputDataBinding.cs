// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The InputDataBinding. </summary>
    public partial class InputDataBinding
    {
        /// <summary> Initializes a new instance of InputDataBinding. </summary>
        public InputDataBinding()
        {
        }

        /// <summary> Initializes a new instance of InputDataBinding. </summary>
        /// <param name="dataId"> ARM resource ID of the registered dataVersion. </param>
        /// <param name="pathOnCompute"> Location of data inside the container process. </param>
        /// <param name="mode"> Mechanism for accessing the data artifact. </param>
        internal InputDataBinding(string dataId, string pathOnCompute, DataBindingMode? mode)
        {
            DataId = dataId;
            PathOnCompute = pathOnCompute;
            Mode = mode;
        }

        /// <summary> ARM resource ID of the registered dataVersion. </summary>
        public string DataId { get; set; }
        /// <summary> Location of data inside the container process. </summary>
        public string PathOnCompute { get; set; }
        /// <summary> Mechanism for accessing the data artifact. </summary>
        public DataBindingMode? Mode { get; set; }
    }
}
