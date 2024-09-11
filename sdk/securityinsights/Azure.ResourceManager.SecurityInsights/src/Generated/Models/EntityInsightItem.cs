// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Entity insight Item. </summary>
    public partial class EntityInsightItem
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

        /// <summary> Initializes a new instance of <see cref="EntityInsightItem"/>. </summary>
        internal EntityInsightItem()
        {
            ChartQueryResults = new ChangeTrackingList<InsightsTableResult>();
        }

        /// <summary> Initializes a new instance of <see cref="EntityInsightItem"/>. </summary>
        /// <param name="queryId"> The query id of the insight. </param>
        /// <param name="queryTimeInterval"> The Time interval that the query actually executed on. </param>
        /// <param name="tableQueryResults"> Query results for table insights query. </param>
        /// <param name="chartQueryResults"> Query results for table insights query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityInsightItem(string queryId, EntityInsightItemQueryTimeInterval queryTimeInterval, InsightsTableResult tableQueryResults, IReadOnlyList<InsightsTableResult> chartQueryResults, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueryId = queryId;
            QueryTimeInterval = queryTimeInterval;
            TableQueryResults = tableQueryResults;
            ChartQueryResults = chartQueryResults;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The query id of the insight. </summary>
        [WirePath("queryId")]
        public string QueryId { get; }
        /// <summary> The Time interval that the query actually executed on. </summary>
        [WirePath("queryTimeInterval")]
        public EntityInsightItemQueryTimeInterval QueryTimeInterval { get; }
        /// <summary> Query results for table insights query. </summary>
        [WirePath("tableQueryResults")]
        public InsightsTableResult TableQueryResults { get; }
        /// <summary> Query results for table insights query. </summary>
        [WirePath("chartQueryResults")]
        public IReadOnlyList<InsightsTableResult> ChartQueryResults { get; }
    }
}
