// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Input parameters necessary for a Conversation task. </summary>
    public partial class ConversationActionContent
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

        /// <summary> Initializes a new instance of <see cref="ConversationActionContent"/>. </summary>
        /// <param name="projectName"> The name of the project to use. </param>
        /// <param name="deploymentName"> The name of the deployment to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public ConversationActionContent(string projectName, string deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            ProjectName = projectName;
            DeploymentName = deploymentName;
            TargetProjectParameters = new ChangeTrackingDictionary<string, AnalysisConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationActionContent"/>. </summary>
        /// <param name="projectName"> The name of the project to use. </param>
        /// <param name="deploymentName"> The name of the deployment to use. </param>
        /// <param name="verbose"> If true, the service will return more detailed information in the response. </param>
        /// <param name="isLoggingEnabled"> If true, the service will keep the query for further review. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        /// <param name="directTarget"> The name of a target project to forward the request to. </param>
        /// <param name="targetProjectParameters">
        /// A dictionary representing the parameters for each target project.
        /// Please note <see cref="AnalysisConfig"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConversationConfig"/>, <see cref="LuisConfig"/> and <see cref="QuestionAnsweringConfig"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationActionContent(string projectName, string deploymentName, bool? verbose, bool? isLoggingEnabled, StringIndexType? stringIndexType, string directTarget, IDictionary<string, AnalysisConfig> targetProjectParameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProjectName = projectName;
            DeploymentName = deploymentName;
            Verbose = verbose;
            IsLoggingEnabled = isLoggingEnabled;
            StringIndexType = stringIndexType;
            DirectTarget = directTarget;
            TargetProjectParameters = targetProjectParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationActionContent"/> for deserialization. </summary>
        internal ConversationActionContent()
        {
        }

        /// <summary> The name of the project to use. </summary>
        public string ProjectName { get; }
        /// <summary> The name of the deployment to use. </summary>
        public string DeploymentName { get; }
        /// <summary> If true, the service will return more detailed information in the response. </summary>
        public bool? Verbose { get; set; }
        /// <summary> If true, the service will keep the query for further review. </summary>
        public bool? IsLoggingEnabled { get; set; }
        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> The name of a target project to forward the request to. </summary>
        public string DirectTarget { get; set; }
        /// <summary>
        /// A dictionary representing the parameters for each target project.
        /// Please note <see cref="AnalysisConfig"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConversationConfig"/>, <see cref="LuisConfig"/> and <see cref="QuestionAnsweringConfig"/>.
        /// </summary>
        public IDictionary<string, AnalysisConfig> TargetProjectParameters { get; }
    }
}
