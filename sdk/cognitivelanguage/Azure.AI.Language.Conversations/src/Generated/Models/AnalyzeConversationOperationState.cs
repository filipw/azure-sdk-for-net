// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Contains the status of the submitted job for analyzing a conversation, along with related statistics. </summary>
    public partial class AnalyzeConversationOperationState
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationOperationState"/>. </summary>
        /// <param name="createdDateTime"> Date and time job created. </param>
        /// <param name="lastUpdatedDateTime"> last updated date and time. </param>
        /// <param name="status"> status. </param>
        /// <param name="actions"> Contains the state for the tasks that are being executed as part of the submitted job for analyzing a conversation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actions"/> is null. </exception>
        internal AnalyzeConversationOperationState(DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, ConversationActionState status, ConversationActions actions)
        {
            Argument.AssertNotNull(actions, nameof(actions));

            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Status = status;
            Errors = new ChangeTrackingList<ConversationError>();
            Actions = actions;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationOperationState"/>. </summary>
        /// <param name="displayName"> display name. </param>
        /// <param name="createdDateTime"> Date and time job created. </param>
        /// <param name="expirationDateTime"> Date and time job expires. </param>
        /// <param name="jobId"> job ID. </param>
        /// <param name="lastUpdatedDateTime"> last updated date and time. </param>
        /// <param name="status"> status. </param>
        /// <param name="errors"> errors. </param>
        /// <param name="nextLink"> next link. </param>
        /// <param name="actions"> Contains the state for the tasks that are being executed as part of the submitted job for analyzing a conversation. </param>
        /// <param name="statistics"> Contains the statistics for the submitted job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeConversationOperationState(string displayName, DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, Guid jobId, DateTimeOffset lastUpdatedDateTime, ConversationActionState status, IReadOnlyList<ConversationError> errors, string nextLink, ConversationActions actions, ConversationRequestStatistics statistics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            CreatedDateTime = createdDateTime;
            ExpirationDateTime = expirationDateTime;
            JobId = jobId;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Status = status;
            Errors = errors;
            NextLink = nextLink;
            Actions = actions;
            Statistics = statistics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationOperationState"/> for deserialization. </summary>
        internal AnalyzeConversationOperationState()
        {
        }

        /// <summary> display name. </summary>
        public string DisplayName { get; }
        /// <summary> Date and time job created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Date and time job expires. </summary>
        public DateTimeOffset? ExpirationDateTime { get; }
        /// <summary> job ID. </summary>
        public Guid JobId { get; }
        /// <summary> last updated date and time. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; }
        /// <summary> status. </summary>
        public ConversationActionState Status { get; }
        /// <summary> errors. </summary>
        public IReadOnlyList<ConversationError> Errors { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
        /// <summary> Contains the state for the tasks that are being executed as part of the submitted job for analyzing a conversation. </summary>
        public ConversationActions Actions { get; }
        /// <summary> Contains the statistics for the submitted job. </summary>
        public ConversationRequestStatistics Statistics { get; }
    }
}
