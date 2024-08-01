// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Result from the personally identifiable information detection and redaction operation performed on a list of conversations. </summary>
    public partial class ConversationPiiOperationResult : AnalyzeConversationOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="ConversationPiiOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="results"> results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal ConversationPiiOperationResult(DateTimeOffset lastUpdateDateTime, ConversationActionState status, ConversationPiiResults results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Kind = AnalyzeConversationOperationResultsKind.PiiOperationResults;
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> discriminator kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="results"> results. </param>
        internal ConversationPiiOperationResult(DateTimeOffset lastUpdateDateTime, ConversationActionState status, string name, AnalyzeConversationOperationResultsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ConversationPiiResults results) : base(lastUpdateDateTime, status, name, kind, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiOperationResult"/> for deserialization. </summary>
        internal ConversationPiiOperationResult()
        {
        }

        /// <summary> results. </summary>
        public ConversationPiiResults Results { get; }
    }
}
