// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The virtual machine instance resource patch definition. </summary>
    public partial class VirtualMachineInstancePatch
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePatch"/>. </summary>
        public VirtualMachineInstancePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePatch"/>. </summary>
        /// <param name="properties"> Defines the resource properties for the update. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineInstancePatch(VirtualMachineInstanceUpdateProperties properties, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Defines the resource properties for the update. </summary>
        public VirtualMachineInstanceUpdateProperties Properties { get; set; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
