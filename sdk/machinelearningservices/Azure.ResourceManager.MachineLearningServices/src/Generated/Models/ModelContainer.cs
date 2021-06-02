// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ModelContainer. </summary>
    public partial class ModelContainer
    {
        /// <summary> Initializes a new instance of ModelContainer. </summary>
        public ModelContainer()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ModelContainer. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        internal ModelContainer(string description, IDictionary<string, string> tags, IDictionary<string, string> properties)
        {
            Description = description;
            Tags = tags;
            Properties = properties;
        }

        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
