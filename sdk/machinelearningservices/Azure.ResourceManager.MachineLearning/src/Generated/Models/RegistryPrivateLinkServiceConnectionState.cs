// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The connection state. </summary>
    public partial class RegistryPrivateLinkServiceConnectionState
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

        /// <summary> Initializes a new instance of <see cref="RegistryPrivateLinkServiceConnectionState"/>. </summary>
        public RegistryPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegistryPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="actionsRequired"> Some RP chose "None". Other RPs use this for region expansion. </param>
        /// <param name="description"> User-defined message that, per NRP doc, may be used for approval-related message. </param>
        /// <param name="status"> Connection status of the service consumer with the service provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegistryPrivateLinkServiceConnectionState(string actionsRequired, string description, EndpointServiceConnectionStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Some RP chose "None". Other RPs use this for region expansion. </summary>
        [WirePath("actionsRequired")]
        public string ActionsRequired { get; set; }
        /// <summary> User-defined message that, per NRP doc, may be used for approval-related message. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> Connection status of the service consumer with the service provider. </summary>
        [WirePath("status")]
        public EndpointServiceConnectionStatus? Status { get; set; }
    }
}
