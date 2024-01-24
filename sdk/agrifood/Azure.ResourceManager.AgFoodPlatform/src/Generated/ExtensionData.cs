// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A class representing the Extension data model.
    /// Extension resource.
    /// </summary>
    public partial class ExtensionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ExtensionData"/>. </summary>
        public ExtensionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> The ETag value to implement optimistic concurrency. </param>
        /// <param name="extensionId"> Extension Id. </param>
        /// <param name="extensionCategory"> Extension category. e.g. weather/sensor/satellite. </param>
        /// <param name="installedExtensionVersion"> Installed extension version. </param>
        /// <param name="extensionAuthLink"> Extension auth link. </param>
        /// <param name="extensionApiDocsLink"> Extension api docs link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtensionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? eTag, string extensionId, string extensionCategory, string installedExtensionVersion, string extensionAuthLink, string extensionApiDocsLink, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            ExtensionId = extensionId;
            ExtensionCategory = extensionCategory;
            InstalledExtensionVersion = installedExtensionVersion;
            ExtensionAuthLink = extensionAuthLink;
            ExtensionApiDocsLink = extensionApiDocsLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ETag value to implement optimistic concurrency. </summary>
        public ETag? ETag { get; }
        /// <summary> Extension Id. </summary>
        public string ExtensionId { get; }
        /// <summary> Extension category. e.g. weather/sensor/satellite. </summary>
        public string ExtensionCategory { get; }
        /// <summary> Installed extension version. </summary>
        public string InstalledExtensionVersion { get; }
        /// <summary> Extension auth link. </summary>
        public string ExtensionAuthLink { get; }
        /// <summary> Extension api docs link. </summary>
        public string ExtensionApiDocsLink { get; }
    }
}
