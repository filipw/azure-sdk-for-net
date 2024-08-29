// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceConnectionUsernamePassword. </summary>
    public partial class MachineLearningWorkspaceConnectionUsernamePassword
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionUsernamePassword"/>. </summary>
        public MachineLearningWorkspaceConnectionUsernamePassword()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionUsernamePassword"/>. </summary>
        /// <param name="password"></param>
        /// <param name="securityToken"> Optional, required by connections like SalesForce for extra security in addition to UsernamePassword. </param>
        /// <param name="username"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceConnectionUsernamePassword(string password, string securityToken, string username, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Password = password;
            SecurityToken = securityToken;
            Username = username;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the password. </summary>
        public string Password { get; set; }
        /// <summary> Optional, required by connections like SalesForce for extra security in addition to UsernamePassword. </summary>
        public string SecurityToken { get; set; }
        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
    }
}
