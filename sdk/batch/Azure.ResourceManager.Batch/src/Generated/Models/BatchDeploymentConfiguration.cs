// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Deployment configuration properties. </summary>
    public partial class BatchDeploymentConfiguration
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

        /// <summary> Initializes a new instance of <see cref="BatchDeploymentConfiguration"/>. </summary>
        public BatchDeploymentConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchDeploymentConfiguration"/>. </summary>
        /// <param name="vmConfiguration"> The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchDeploymentConfiguration(BatchVmConfiguration vmConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmConfiguration = vmConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure. </summary>
        public BatchVmConfiguration VmConfiguration { get; set; }
    }
}
