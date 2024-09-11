// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Azure Active Directory token validation flow. </summary>
    public partial class ContainerAppAzureActiveDirectoryValidationConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureActiveDirectoryValidationConfiguration"/>. </summary>
        public ContainerAppAzureActiveDirectoryValidationConfiguration()
        {
            AllowedAudiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureActiveDirectoryValidationConfiguration"/>. </summary>
        /// <param name="jwtClaimChecks"> The configuration settings of the checks that should be made while validating the JWT Claims. </param>
        /// <param name="allowedAudiences"> The list of audiences that can make successful authentication/authorization requests. </param>
        /// <param name="defaultAuthorizationPolicy"> The configuration settings of the default authorization policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppAzureActiveDirectoryValidationConfiguration(ContainerAppJwtClaimChecks jwtClaimChecks, IList<string> allowedAudiences, ContainerAppDefaultAuthorizationPolicy defaultAuthorizationPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JwtClaimChecks = jwtClaimChecks;
            AllowedAudiences = allowedAudiences;
            DefaultAuthorizationPolicy = defaultAuthorizationPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration settings of the checks that should be made while validating the JWT Claims. </summary>
        [WirePath("jwtClaimChecks")]
        public ContainerAppJwtClaimChecks JwtClaimChecks { get; set; }
        /// <summary> The list of audiences that can make successful authentication/authorization requests. </summary>
        [WirePath("allowedAudiences")]
        public IList<string> AllowedAudiences { get; }
        /// <summary> The configuration settings of the default authorization policy. </summary>
        [WirePath("defaultAuthorizationPolicy")]
        public ContainerAppDefaultAuthorizationPolicy DefaultAuthorizationPolicy { get; set; }
    }
}
