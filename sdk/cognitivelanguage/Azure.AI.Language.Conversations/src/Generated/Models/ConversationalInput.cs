// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The input for a custom conversation task. </summary>
    public partial class ConversationalInput : AnalyzeConversationInput
    {
        /// <summary> Initializes a new instance of <see cref="ConversationalInput"/>. </summary>
        /// <param name="conversationInput"> The input ConversationItem and its optional parameters. </param>
        /// <param name="actionContent"> Input parameters necessary for a Conversation task. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationInput"/> or <paramref name="actionContent"/> is null. </exception>
        public ConversationalInput(ConversationAnalysisInput conversationInput, ConversationActionContent actionContent)
        {
            Argument.AssertNotNull(conversationInput, nameof(conversationInput));
            Argument.AssertNotNull(actionContent, nameof(actionContent));

            Kind = AnalyzeConversationInputKind.Conversation;
            ConversationInput = conversationInput;
            ActionContent = actionContent;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalInput"/>. </summary>
        /// <param name="kind"> The base class of a conversation input task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="conversationInput"> The input ConversationItem and its optional parameters. </param>
        /// <param name="actionContent"> Input parameters necessary for a Conversation task. </param>
        internal ConversationalInput(AnalyzeConversationInputKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ConversationAnalysisInput conversationInput, ConversationActionContent actionContent) : base(kind, serializedAdditionalRawData)
        {
            ConversationInput = conversationInput;
            ActionContent = actionContent;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalInput"/> for deserialization. </summary>
        internal ConversationalInput()
        {
        }

        /// <summary> The input ConversationItem and its optional parameters. </summary>
        public ConversationAnalysisInput ConversationInput { get; }
        /// <summary> Input parameters necessary for a Conversation task. </summary>
        public ConversationActionContent ActionContent { get; }
    }
}
