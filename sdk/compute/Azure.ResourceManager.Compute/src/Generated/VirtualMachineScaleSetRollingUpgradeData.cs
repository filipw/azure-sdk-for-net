// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the VirtualMachineScaleSetRollingUpgrade data model.
    /// The status of the latest virtual machine scale set rolling upgrade.
    /// </summary>
    public partial class VirtualMachineScaleSetRollingUpgradeData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetRollingUpgradeData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineScaleSetRollingUpgradeData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetRollingUpgradeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="policy"> The rolling upgrade policies applied for this upgrade. </param>
        /// <param name="runningStatus"> Information about the current running state of the overall upgrade. </param>
        /// <param name="progress"> Information about the number of virtual machine instances in each upgrade state. </param>
        /// <param name="error"> Error details for this upgrade, if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetRollingUpgradeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RollingUpgradePolicy policy, RollingUpgradeRunningStatus runningStatus, RollingUpgradeProgressInfo progress, ComputeApiError error, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Policy = policy;
            RunningStatus = runningStatus;
            Progress = progress;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetRollingUpgradeData"/> for deserialization. </summary>
        internal VirtualMachineScaleSetRollingUpgradeData()
        {
        }

        /// <summary> The rolling upgrade policies applied for this upgrade. </summary>
        public RollingUpgradePolicy Policy { get; }
        /// <summary> Information about the current running state of the overall upgrade. </summary>
        public RollingUpgradeRunningStatus RunningStatus { get; }
        /// <summary> Information about the number of virtual machine instances in each upgrade state. </summary>
        public RollingUpgradeProgressInfo Progress { get; }
        /// <summary> Error details for this upgrade, if there are any. </summary>
        public ComputeApiError Error { get; }
    }
}
