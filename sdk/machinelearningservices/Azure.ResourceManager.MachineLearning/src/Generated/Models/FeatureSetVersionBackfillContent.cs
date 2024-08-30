// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Request payload for creating a backfill request for a given feature set version. </summary>
    public partial class FeatureSetVersionBackfillContent
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

        /// <summary> Initializes a new instance of <see cref="FeatureSetVersionBackfillContent"/>. </summary>
        public FeatureSetVersionBackfillContent()
        {
            DataAvailabilityStatus = new ChangeTrackingList<DataAvailabilityStatus>();
            Properties = new ChangeTrackingDictionary<string, string>();
            SparkConfiguration = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="FeatureSetVersionBackfillContent"/>. </summary>
        /// <param name="dataAvailabilityStatus"> Specified the data availability status that you want to backfill. </param>
        /// <param name="description"> Specifies description. </param>
        /// <param name="displayName"> Specifies description. </param>
        /// <param name="featureWindow"> Specifies the backfill feature window to be materialized. </param>
        /// <param name="jobId"> Specify the jobId to retry the failed materialization. </param>
        /// <param name="properties"> Specifies the properties. </param>
        /// <param name="resource"> Specifies the compute resource settings. </param>
        /// <param name="sparkConfiguration"> Specifies the spark compute settings. </param>
        /// <param name="tags"> Specifies the tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FeatureSetVersionBackfillContent(IList<DataAvailabilityStatus> dataAvailabilityStatus, string description, string displayName, FeatureWindow featureWindow, string jobId, IDictionary<string, string> properties, MaterializationComputeResource resource, IDictionary<string, string> sparkConfiguration, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataAvailabilityStatus = dataAvailabilityStatus;
            Description = description;
            DisplayName = displayName;
            FeatureWindow = featureWindow;
            JobId = jobId;
            Properties = properties;
            Resource = resource;
            SparkConfiguration = sparkConfiguration;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specified the data availability status that you want to backfill. </summary>
        [WirePath("dataAvailabilityStatus")]
        public IList<DataAvailabilityStatus> DataAvailabilityStatus { get; }
        /// <summary> Specifies description. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> Specifies description. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; set; }
        /// <summary> Specifies the backfill feature window to be materialized. </summary>
        [WirePath("featureWindow")]
        public FeatureWindow FeatureWindow { get; set; }
        /// <summary> Specify the jobId to retry the failed materialization. </summary>
        [WirePath("jobId")]
        public string JobId { get; set; }
        /// <summary> Specifies the properties. </summary>
        [WirePath("properties")]
        public IDictionary<string, string> Properties { get; }
        /// <summary> Specifies the compute resource settings. </summary>
        internal MaterializationComputeResource Resource { get; set; }
        /// <summary> Specifies the instance type. </summary>
        [WirePath("resource.instanceType")]
        public string ResourceInstanceType
        {
            get => Resource is null ? default : Resource.InstanceType;
            set
            {
                if (Resource is null)
                    Resource = new MaterializationComputeResource();
                Resource.InstanceType = value;
            }
        }

        /// <summary> Specifies the spark compute settings. </summary>
        [WirePath("sparkConfiguration")]
        public IDictionary<string, string> SparkConfiguration { get; }
        /// <summary> Specifies the tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
    }
}
