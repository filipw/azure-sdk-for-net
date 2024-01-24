// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies ProxyAgent settings while creating the virtual machine. Minimum api-version: 2023-09-01. </summary>
    public partial class ProxyAgentSettings
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

        /// <summary> Initializes a new instance of <see cref="ProxyAgentSettings"/>. </summary>
        public ProxyAgentSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProxyAgentSettings"/>. </summary>
        /// <param name="enabled"> Specifies whether ProxyAgent feature should be enabled on the virtual machine or virtual machine scale set. </param>
        /// <param name="mode"> Specifies the mode that ProxyAgent will execute on if the feature is enabled. ProxyAgent will start to audit or monitor but not enforce access control over requests to host endpoints in Audit mode, while in Enforce mode it will enforce access control. The default value is Enforce mode. </param>
        /// <param name="keyIncarnationId"> Increase the value of this property allows user to reset the key used for securing communication channel between guest and host. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProxyAgentSettings(bool? enabled, Mode? mode, int? keyIncarnationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            Mode = mode;
            KeyIncarnationId = keyIncarnationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies whether ProxyAgent feature should be enabled on the virtual machine or virtual machine scale set. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Specifies the mode that ProxyAgent will execute on if the feature is enabled. ProxyAgent will start to audit or monitor but not enforce access control over requests to host endpoints in Audit mode, while in Enforce mode it will enforce access control. The default value is Enforce mode. </summary>
        public Mode? Mode { get; set; }
        /// <summary> Increase the value of this property allows user to reset the key used for securing communication channel between guest and host. </summary>
        public int? KeyIncarnationId { get; set; }
    }
}
