// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn device configuration script generation parameters. </summary>
    public partial class VpnDeviceScriptContent
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

        /// <summary> Initializes a new instance of <see cref="VpnDeviceScriptContent"/>. </summary>
        public VpnDeviceScriptContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnDeviceScriptContent"/>. </summary>
        /// <param name="vendor"> The vendor for the vpn device. </param>
        /// <param name="deviceFamily"> The device family for the vpn device. </param>
        /// <param name="firmwareVersion"> The firmware version for the vpn device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnDeviceScriptContent(string vendor, string deviceFamily, string firmwareVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Vendor = vendor;
            DeviceFamily = deviceFamily;
            FirmwareVersion = firmwareVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The vendor for the vpn device. </summary>
        public string Vendor { get; set; }
        /// <summary> The device family for the vpn device. </summary>
        public string DeviceFamily { get; set; }
        /// <summary> The firmware version for the vpn device. </summary>
        public string FirmwareVersion { get; set; }
    }
}
