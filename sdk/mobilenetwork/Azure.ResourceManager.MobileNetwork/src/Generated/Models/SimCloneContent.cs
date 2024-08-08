// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The SIMs to clone.
    /// Serialized Name: SimClone
    /// </summary>
    public partial class SimCloneContent
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

        /// <summary> Initializes a new instance of <see cref="SimCloneContent"/>. </summary>
        public SimCloneContent()
        {
            Sims = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SimCloneContent"/>. </summary>
        /// <param name="targetSimGroupId">
        /// The SIM Group where the SIMs should be cloned.
        /// Serialized Name: SimClone.targetSimGroupId
        /// </param>
        /// <param name="sims">
        /// A list of SIM resource names to be cloned.
        /// Serialized Name: SimClone.sims
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SimCloneContent(SubResource targetSimGroupId, IList<string> sims, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetSimGroupId = targetSimGroupId;
            Sims = sims;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The SIM Group where the SIMs should be cloned.
        /// Serialized Name: SimClone.targetSimGroupId
        /// </summary>
        internal SubResource TargetSimGroupId { get; set; }
        /// <summary> Gets Id. </summary>
        [WirePath("targetSimGroupId.id")]
        public ResourceIdentifier TargetSimGroupIdId
        {
            get => TargetSimGroupId is null ? default : TargetSimGroupId.Id;
        }

        /// <summary>
        /// A list of SIM resource names to be cloned.
        /// Serialized Name: SimClone.sims
        /// </summary>
        [WirePath("sims")]
        public IList<string> Sims { get; }
    }
}
