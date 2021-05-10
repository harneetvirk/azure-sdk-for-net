// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary>
    /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
    /// 
    /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
    /// </summary>
    internal partial class InnerErrorV2
    {
        /// <summary> Initializes a new instance of InnerErrorV2. </summary>
        /// <param name="code"> Gets code error string. </param>
        /// <param name="message"> Gets high level error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal InnerErrorV2(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of InnerErrorV2. </summary>
        /// <param name="code"> Gets code error string. </param>
        /// <param name="message"> Gets high level error message. </param>
        /// <param name="target">
        /// Gets the source of the error.
        /// 
        /// For example it would be &quot;documents&quot; or &quot;document id&quot; in case of invalid document.
        /// </param>
        /// <param name="innerError">
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// 
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </param>
        internal InnerErrorV2(string code, string message, string target, InnerErrorV2 innerError)
        {
            Code = code;
            Message = message;
            Target = target;
            InnerError = innerError;
        }

        /// <summary> Gets code error string. </summary>
        public string Code { get; }
        /// <summary> Gets high level error message. </summary>
        public string Message { get; }
        /// <summary>
        /// Gets the source of the error.
        /// 
        /// For example it would be &quot;documents&quot; or &quot;document id&quot; in case of invalid document.
        /// </summary>
        public string Target { get; }
        /// <summary>
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// 
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </summary>
        public InnerErrorV2 InnerError { get; }
    }
}
