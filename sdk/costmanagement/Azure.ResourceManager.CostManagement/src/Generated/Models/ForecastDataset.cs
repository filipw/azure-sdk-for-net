// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The definition of data present in the forecast. </summary>
    public partial class ForecastDataset
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

        /// <summary> Initializes a new instance of <see cref="ForecastDataset"/>. </summary>
        /// <param name="aggregation"> Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the aggregated column. forecast can have up to 2 aggregation clauses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregation"/> is null. </exception>
        public ForecastDataset(IDictionary<string, ForecastAggregation> aggregation)
        {
            Argument.AssertNotNull(aggregation, nameof(aggregation));

            Aggregation = aggregation;
        }

        /// <summary> Initializes a new instance of <see cref="ForecastDataset"/>. </summary>
        /// <param name="granularity"> The granularity of rows in the forecast. </param>
        /// <param name="configuration"> Has configuration information for the data in the export. The configuration will be ignored if aggregation and grouping are provided. </param>
        /// <param name="aggregation"> Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the aggregated column. forecast can have up to 2 aggregation clauses. </param>
        /// <param name="filter"> Has filter expression to use in the forecast. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ForecastDataset(GranularityType? granularity, ForecastDatasetConfiguration configuration, IDictionary<string, ForecastAggregation> aggregation, ForecastFilter filter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Granularity = granularity;
            Configuration = configuration;
            Aggregation = aggregation;
            Filter = filter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ForecastDataset"/> for deserialization. </summary>
        internal ForecastDataset()
        {
        }

        /// <summary> The granularity of rows in the forecast. </summary>
        public GranularityType? Granularity { get; set; }
        /// <summary> Has configuration information for the data in the export. The configuration will be ignored if aggregation and grouping are provided. </summary>
        internal ForecastDatasetConfiguration Configuration { get; set; }
        /// <summary> Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then forecast includes all columns. </summary>
        public IList<string> Columns
        {
            get
            {
                if (Configuration is null)
                    Configuration = new ForecastDatasetConfiguration();
                return Configuration.Columns;
            }
        }

        /// <summary> Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the aggregated column. forecast can have up to 2 aggregation clauses. </summary>
        public IDictionary<string, ForecastAggregation> Aggregation { get; }
        /// <summary> Has filter expression to use in the forecast. </summary>
        public ForecastFilter Filter { get; set; }
    }
}
