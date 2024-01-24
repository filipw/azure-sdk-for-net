// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the endpoints used for the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectConfig
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectConfig"/>. </summary>
        public ContainerAppOpenIdConnectConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectConfig"/>. </summary>
        /// <param name="authorizationEndpoint"> The endpoint to be used to make an authorization request. </param>
        /// <param name="tokenEndpoint"> The endpoint to be used to request a token. </param>
        /// <param name="issuer"> The endpoint that issues the token. </param>
        /// <param name="certificationUri"> The endpoint that provides the keys necessary to validate the token. </param>
        /// <param name="wellKnownOpenIdConfiguration"> The endpoint that contains all the configuration endpoints for the provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppOpenIdConnectConfig(string authorizationEndpoint, string tokenEndpoint, string issuer, Uri certificationUri, string wellKnownOpenIdConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthorizationEndpoint = authorizationEndpoint;
            TokenEndpoint = tokenEndpoint;
            Issuer = issuer;
            CertificationUri = certificationUri;
            WellKnownOpenIdConfiguration = wellKnownOpenIdConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The endpoint to be used to make an authorization request. </summary>
        public string AuthorizationEndpoint { get; set; }
        /// <summary> The endpoint to be used to request a token. </summary>
        public string TokenEndpoint { get; set; }
        /// <summary> The endpoint that issues the token. </summary>
        public string Issuer { get; set; }
        /// <summary> The endpoint that provides the keys necessary to validate the token. </summary>
        public Uri CertificationUri { get; set; }
        /// <summary> The endpoint that contains all the configuration endpoints for the provider. </summary>
        public string WellKnownOpenIdConfiguration { get; set; }
    }
}
