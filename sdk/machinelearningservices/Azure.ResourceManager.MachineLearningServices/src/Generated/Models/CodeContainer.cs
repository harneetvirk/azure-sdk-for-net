// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Container for code asset versions. </summary>
    public partial class CodeContainer
    {
        /// <summary> Initializes a new instance of CodeContainer. </summary>
        public CodeContainer()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CodeContainer. </summary>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="description"> The asset description text. </param>
        internal CodeContainer(IDictionary<string, string> properties, IDictionary<string, string> tags, string description)
        {
            Properties = properties;
            Tags = tags;
            Description = description;
        }

        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
    }
}
