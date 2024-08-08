// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents a sentence target and the assessments or target objects related to it. </summary>
    public partial class SentenceTarget
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

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/>. </summary>
        /// <param name="sentiment"> The sentiment of the sentence. </param>
        /// <param name="confidenceScores"> Represents the confidence scores across all sentiment classes: positive and negative. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <param name="text"> The target text detected. </param>
        /// <param name="relations"> The array of either assessment or target objects which is related to the target. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="confidenceScores"/>, <paramref name="text"/> or <paramref name="relations"/> is null. </exception>
        internal SentenceTarget(TokenSentiment sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, IEnumerable<TargetRelation> relations)
        {
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(relations, nameof(relations));

            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            Relations = relations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/>. </summary>
        /// <param name="sentiment"> The sentiment of the sentence. </param>
        /// <param name="confidenceScores"> Represents the confidence scores across all sentiment classes: positive and negative. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <param name="text"> The target text detected. </param>
        /// <param name="relations"> The array of either assessment or target objects which is related to the target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceTarget(TokenSentiment sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, IReadOnlyList<TargetRelation> relations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            Relations = relations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/> for deserialization. </summary>
        internal SentenceTarget()
        {
        }

        /// <summary> The sentiment of the sentence. </summary>
        public TokenSentiment Sentiment { get; }
        /// <summary> Represents the confidence scores across all sentiment classes: positive and negative. </summary>
        public TargetConfidenceScoreLabel ConfidenceScores { get; }
        /// <summary> The target offset from the start of the sentence. </summary>
        public int Offset { get; }
        /// <summary> The length of the target. </summary>
        public int Length { get; }
        /// <summary> The target text detected. </summary>
        public string Text { get; }
        /// <summary> The array of either assessment or target objects which is related to the target. </summary>
        public IReadOnlyList<TargetRelation> Relations { get; }
    }
}
