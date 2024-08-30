// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Outbound Rule for the managed network of a machine learning workspace.
    /// Please note <see cref="MachineLearningOutboundRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FqdnOutboundRule"/>, <see cref="PrivateEndpointOutboundRule"/> and <see cref="ServiceTagOutboundRule"/>.
    /// </summary>
    public abstract partial class MachineLearningOutboundRule
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningOutboundRule"/>. </summary>
        protected MachineLearningOutboundRule()
        {
            ParentRuleNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningOutboundRule"/>. </summary>
        /// <param name="category"> Category of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="parentRuleNames"></param>
        /// <param name="status"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="outboundRuleType"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningOutboundRule(OutboundRuleCategory? category, IReadOnlyList<string> parentRuleNames, OutboundRuleStatus? status, OutboundRuleType outboundRuleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            ParentRuleNames = parentRuleNames;
            Status = status;
            OutboundRuleType = outboundRuleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Category of a managed network Outbound Rule of a machine learning workspace. </summary>
        [WirePath("category")]
        public OutboundRuleCategory? Category { get; set; }
        /// <summary> Gets the parent rule names. </summary>
        [WirePath("parentRuleNames")]
        public IReadOnlyList<string> ParentRuleNames { get; }
        /// <summary> Type of a managed network Outbound Rule of a machine learning workspace. </summary>
        [WirePath("status")]
        public OutboundRuleStatus? Status { get; set; }
        /// <summary> Type of a managed network Outbound Rule of a machine learning workspace. </summary>
        internal OutboundRuleType OutboundRuleType { get; set; }
    }
}
