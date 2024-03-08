// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> The text analysis request. </summary>
    public partial class AnalyzeTextOptions
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/>. </summary>
        /// <param name="text"> The text needs to be analyzed. We support a maximum of 10k Unicode characters (Unicode code points) in the text of one request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public AnalyzeTextOptions(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            Categories = new ChangeTrackingList<TextCategory>();
            BlocklistNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/>. </summary>
        /// <param name="text"> The text needs to be analyzed. We support a maximum of 10k Unicode characters (Unicode code points) in the text of one request. </param>
        /// <param name="categories"> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </param>
        /// <param name="blocklistNames"> The names of blocklists. </param>
        /// <param name="haltOnBlocklistHit"> When set to true, further analyses of harmful content will not be performed in cases where blocklists are hit. When set to false, all analyses of harmful content will be performed, whether or not blocklists are hit. </param>
        /// <param name="outputType"> This refers to the type of text analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeTextOptions(string text, IList<TextCategory> categories, IList<string> blocklistNames, bool? haltOnBlocklistHit, AnalyzeTextOutputType? outputType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Categories = categories;
            BlocklistNames = blocklistNames;
            HaltOnBlocklistHit = haltOnBlocklistHit;
            OutputType = outputType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/> for deserialization. </summary>
        internal AnalyzeTextOptions()
        {
        }

        /// <summary> The text needs to be analyzed. We support a maximum of 10k Unicode characters (Unicode code points) in the text of one request. </summary>
        public string Text { get; }
        /// <summary> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </summary>
        public IList<TextCategory> Categories { get; }
        /// <summary> The names of blocklists. </summary>
        public IList<string> BlocklistNames { get; }
        /// <summary> When set to true, further analyses of harmful content will not be performed in cases where blocklists are hit. When set to false, all analyses of harmful content will be performed, whether or not blocklists are hit. </summary>
        public bool? HaltOnBlocklistHit { get; set; }
        /// <summary> This refers to the type of text analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </summary>
        public AnalyzeTextOutputType? OutputType { get; set; }
    }
}
