// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Network Security Perimeter profile. </summary>
    public partial class NetworkSecurityPerimeterProfile
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfile"/>. </summary>
        internal NetworkSecurityPerimeterProfile()
        {
            AccessRules = new ChangeTrackingList<HybridComputeAccessRule>();
            EnabledLogCategories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfile"/>. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="accessRulesVersion"> Access rules version number. </param>
        /// <param name="accessRules"> Collection of access rules for the profile. </param>
        /// <param name="diagnosticSettingsVersion"> Diagnostic settings version number. </param>
        /// <param name="enabledLogCategories"> Collection of enabled log categories for the profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterProfile(string name, int? accessRulesVersion, IReadOnlyList<HybridComputeAccessRule> accessRules, int? diagnosticSettingsVersion, IReadOnlyList<string> enabledLogCategories, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessRulesVersion = accessRulesVersion;
            AccessRules = accessRules;
            DiagnosticSettingsVersion = diagnosticSettingsVersion;
            EnabledLogCategories = enabledLogCategories;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the resource. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Access rules version number. </summary>
        [WirePath("accessRulesVersion")]
        public int? AccessRulesVersion { get; }
        /// <summary> Collection of access rules for the profile. </summary>
        [WirePath("accessRules")]
        public IReadOnlyList<HybridComputeAccessRule> AccessRules { get; }
        /// <summary> Diagnostic settings version number. </summary>
        [WirePath("diagnosticSettingsVersion")]
        public int? DiagnosticSettingsVersion { get; }
        /// <summary> Collection of enabled log categories for the profile. </summary>
        [WirePath("enabledLogCategories")]
        public IReadOnlyList<string> EnabledLogCategories { get; }
    }
}
