// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex dependencies. </summary>
    public partial class SecurityInsightsMetadataDependencies
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMetadataDependencies"/>. </summary>
        public SecurityInsightsMetadataDependencies()
        {
            Criteria = new ChangeTrackingList<SecurityInsightsMetadataDependencies>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMetadataDependencies"/>. </summary>
        /// <param name="contentId"> Id of the content item we depend on. </param>
        /// <param name="kind"> Type of the content item we depend on. </param>
        /// <param name="version"> Version of the the content item we depend on.  Can be blank, * or missing to indicate any version fulfills the dependency.  If version does not match our defined numeric format then an exact match is required. </param>
        /// <param name="name"> Name of the content item. </param>
        /// <param name="operator"> Operator used for list of dependencies in criteria array. </param>
        /// <param name="criteria"> This is the list of dependencies we must fulfill, according to the AND/OR operator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsMetadataDependencies(string contentId, SecurityInsightsKind? kind, string version, string name, ThreatIntelligenceQueryOperator? @operator, IList<SecurityInsightsMetadataDependencies> criteria, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentId = contentId;
            Kind = kind;
            Version = version;
            Name = name;
            Operator = @operator;
            Criteria = criteria;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id of the content item we depend on. </summary>
        [WirePath("contentId")]
        public string ContentId { get; set; }
        /// <summary> Type of the content item we depend on. </summary>
        [WirePath("kind")]
        public SecurityInsightsKind? Kind { get; set; }
        /// <summary> Version of the the content item we depend on.  Can be blank, * or missing to indicate any version fulfills the dependency.  If version does not match our defined numeric format then an exact match is required. </summary>
        [WirePath("version")]
        public string Version { get; set; }
        /// <summary> Name of the content item. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Operator used for list of dependencies in criteria array. </summary>
        [WirePath("operator")]
        public ThreatIntelligenceQueryOperator? Operator { get; set; }
        /// <summary> This is the list of dependencies we must fulfill, according to the AND/OR operator. </summary>
        [WirePath("criteria")]
        public IList<SecurityInsightsMetadataDependencies> Criteria { get; }
    }
}
