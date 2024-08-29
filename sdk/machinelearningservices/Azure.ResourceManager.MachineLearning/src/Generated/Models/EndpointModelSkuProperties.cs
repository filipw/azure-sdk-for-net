// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The EndpointModelSkuProperties. </summary>
    public partial class EndpointModelSkuProperties
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

        /// <summary> Initializes a new instance of <see cref="EndpointModelSkuProperties"/>. </summary>
        internal EndpointModelSkuProperties()
        {
            ConnectionIds = new ChangeTrackingList<ResourceIdentifier>();
            RateLimits = new ChangeTrackingList<EndpointModelSkuRateLimitProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointModelSkuProperties"/>. </summary>
        /// <param name="capacity"></param>
        /// <param name="connectionIds"> The list of ARM id for the connection support this SKU. </param>
        /// <param name="deprecationOn"> The datetime of deprecation of the model SKU. </param>
        /// <param name="name"> The name of the model SKU. </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageName"> The usage name of the model SKU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointModelSkuProperties(EndpointModelSkuCapacityProperties capacity, IReadOnlyList<ResourceIdentifier> connectionIds, DateTimeOffset? deprecationOn, string name, IReadOnlyList<EndpointModelSkuRateLimitProperties> rateLimits, string usageName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Capacity = capacity;
            ConnectionIds = connectionIds;
            DeprecationOn = deprecationOn;
            Name = name;
            RateLimits = rateLimits;
            UsageName = usageName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the capacity. </summary>
        public EndpointModelSkuCapacityProperties Capacity { get; }
        /// <summary> The list of ARM id for the connection support this SKU. </summary>
        public IReadOnlyList<ResourceIdentifier> ConnectionIds { get; }
        /// <summary> The datetime of deprecation of the model SKU. </summary>
        public DateTimeOffset? DeprecationOn { get; }
        /// <summary> The name of the model SKU. </summary>
        public string Name { get; }
        /// <summary> Gets the rate limits. </summary>
        public IReadOnlyList<EndpointModelSkuRateLimitProperties> RateLimits { get; }
        /// <summary> The usage name of the model SKU. </summary>
        public string UsageName { get; }
    }
}
