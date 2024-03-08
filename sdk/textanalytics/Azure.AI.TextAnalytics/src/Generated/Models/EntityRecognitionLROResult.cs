// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntityRecognitionLROResult. </summary>
    internal partial class EntityRecognitionLROResult : AnalyzeTextLROResult
    {
        /// <summary> Initializes a new instance of <see cref="EntityRecognitionLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        public EntityRecognitionLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, EntitiesResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results;
            Kind = AnalyzeTextLROResultsKind.EntityRecognitionLROResults;
        }

        /// <summary> Initializes a new instance of <see cref="EntityRecognitionLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="kind"> Enumeration of supported Text Analysis long-running operation task results. </param>
        /// <param name="taskName"></param>
        /// <param name="results"></param>
        internal EntityRecognitionLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, AnalyzeTextLROResultsKind kind, string taskName, EntitiesResult results) : base(lastUpdateDateTime, status, kind, taskName)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Gets or sets the results. </summary>
        public EntitiesResult Results { get; set; }
    }
}
