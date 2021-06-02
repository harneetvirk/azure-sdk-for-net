// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The Environment, models and assets used for inferencing. </summary>
    public partial class ACIServiceResponseEnvironmentImageRequest : EnvironmentImageResponse
    {
        /// <summary> Initializes a new instance of ACIServiceResponseEnvironmentImageRequest. </summary>
        public ACIServiceResponseEnvironmentImageRequest()
        {
        }

        /// <summary> Initializes a new instance of ACIServiceResponseEnvironmentImageRequest. </summary>
        /// <param name="driverProgram"> The name of the driver file. </param>
        /// <param name="assets"> The list of assets. </param>
        /// <param name="modelIds"> The list of model Ids. </param>
        /// <param name="models"> The list of models. </param>
        /// <param name="environment"> The details of the AZURE ML environment. </param>
        /// <param name="environmentReference"> The unique identifying details of the AZURE ML environment. </param>
        internal ACIServiceResponseEnvironmentImageRequest(string driverProgram, IList<ImageAsset> assets, IList<string> modelIds, IList<Model> models, EnvironmentImageResponseEnvironment environment, EnvironmentImageResponseEnvironmentReference environmentReference) : base(driverProgram, assets, modelIds, models, environment, environmentReference)
        {
        }
    }
}
