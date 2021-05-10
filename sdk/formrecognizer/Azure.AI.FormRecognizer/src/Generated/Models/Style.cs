// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> An object representing the style of the text line. </summary>
    internal partial class Style
    {
        /// <summary> Initializes a new instance of Style. </summary>
        /// <param name="name"> The text line style name, including handwriting and other. </param>
        /// <param name="confidence"> The confidence of text line style. </param>
        internal Style(TextStyleName name, float confidence)
        {
            Name = name;
            Confidence = confidence;
        }

        /// <summary> The text line style name, including handwriting and other. </summary>
        public TextStyleName Name { get; }
        /// <summary> The confidence of text line style. </summary>
        public float Confidence { get; }
    }
}
