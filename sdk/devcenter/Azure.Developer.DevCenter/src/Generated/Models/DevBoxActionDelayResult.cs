// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> The action delay result. </summary>
    public partial class DevBoxActionDelayResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevBoxActionDelayResult"/>. </summary>
        /// <param name="actionName"> The name of the action. </param>
        /// <param name="result"> The result of the delay operation on this action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionName"/> is null. </exception>
        internal DevBoxActionDelayResult(string actionName, DevBoxActionDelayStatus result)
        {
            Argument.AssertNotNull(actionName, nameof(actionName));

            ActionName = actionName;
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="DevBoxActionDelayResult"/>. </summary>
        /// <param name="actionName"> The name of the action. </param>
        /// <param name="result"> The result of the delay operation on this action. </param>
        /// <param name="action"> The delayed action. </param>
        /// <param name="error"> Information about the error that occurred. Only populated on error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevBoxActionDelayResult(string actionName, DevBoxActionDelayStatus result, DevBoxAction action, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionName = actionName;
            Result = result;
            Action = action;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevBoxActionDelayResult"/> for deserialization. </summary>
        internal DevBoxActionDelayResult()
        {
        }

        /// <summary> The name of the action. </summary>
        public string ActionName { get; }
        /// <summary> The result of the delay operation on this action. </summary>
        public DevBoxActionDelayStatus Result { get; }
        /// <summary> The delayed action. </summary>
        public DevBoxAction Action { get; }
        /// <summary> Information about the error that occurred. Only populated on error. </summary>
        public ResponseError Error { get; }
    }
}
