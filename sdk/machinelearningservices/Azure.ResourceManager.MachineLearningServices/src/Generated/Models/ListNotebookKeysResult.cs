// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ListNotebookKeysResult. </summary>
    public partial class ListNotebookKeysResult
    {
        /// <summary> Initializes a new instance of ListNotebookKeysResult. </summary>
        internal ListNotebookKeysResult()
        {
        }

        /// <summary> Initializes a new instance of ListNotebookKeysResult. </summary>
        /// <param name="primaryAccessKey"> . </param>
        /// <param name="secondaryAccessKey"> . </param>
        internal ListNotebookKeysResult(string primaryAccessKey, string secondaryAccessKey)
        {
            PrimaryAccessKey = primaryAccessKey;
            SecondaryAccessKey = secondaryAccessKey;
        }

        public string PrimaryAccessKey { get; }
        public string SecondaryAccessKey { get; }
    }
}
