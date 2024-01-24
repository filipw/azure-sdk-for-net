// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Cache update details. </summary>
    public partial class ApiManagementCachePatch
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementCachePatch"/>. </summary>
        public ApiManagementCachePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementCachePatch"/>. </summary>
        /// <param name="description"> Cache description. </param>
        /// <param name="connectionString"> Runtime connection string to cache. </param>
        /// <param name="useFromLocation"> Location identifier to use cache from (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="resourceUri"> Original uri of entity in external system cache points to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementCachePatch(string description, string connectionString, string useFromLocation, Uri resourceUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            ConnectionString = connectionString;
            UseFromLocation = useFromLocation;
            ResourceUri = resourceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cache description. </summary>
        public string Description { get; set; }
        /// <summary> Runtime connection string to cache. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Location identifier to use cache from (should be either 'default' or valid Azure region identifier). </summary>
        public string UseFromLocation { get; set; }
        /// <summary> Original uri of entity in external system cache points to. </summary>
        public Uri ResourceUri { get; set; }
    }
}
