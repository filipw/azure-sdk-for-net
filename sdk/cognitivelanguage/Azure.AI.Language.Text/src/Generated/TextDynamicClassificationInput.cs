// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the analyze text dynamic classifications input. </summary>
    public partial class TextDynamicClassificationInput : AnalyzeTextInput
    {
        /// <summary> Initializes a new instance of <see cref="TextDynamicClassificationInput"/>. </summary>
        public TextDynamicClassificationInput()
        {
            Kind = AnalyzeTextInputKind.DynamicClassification;
        }

        /// <summary> Initializes a new instance of <see cref="TextDynamicClassificationInput"/>. </summary>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="textInput"> Input to be analyzed. </param>
        /// <param name="actionContent"> Task parameters. </param>
        internal TextDynamicClassificationInput(AnalyzeTextInputKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, MultiLanguageTextInput textInput, DynamicClassificationActionContent actionContent) : base(kind, serializedAdditionalRawData)
        {
            TextInput = textInput;
            ActionContent = actionContent;
        }

        /// <summary> Input to be analyzed. </summary>
        public MultiLanguageTextInput TextInput { get; set; }
        /// <summary> Task parameters. </summary>
        public DynamicClassificationActionContent ActionContent { get; set; }
    }
}
