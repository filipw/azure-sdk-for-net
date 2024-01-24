// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Url signing key. </summary>
    public partial class UriSigningKey
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

        /// <summary> Initializes a new instance of <see cref="UriSigningKey"/>. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="keySourceParameters"> Defines the parameters for using customer key vault for Url Signing Key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyId"/> or <paramref name="keySourceParameters"/> is null. </exception>
        public UriSigningKey(string keyId, KeyVaultSigningKey keySourceParameters)
        {
            Argument.AssertNotNull(keyId, nameof(keyId));
            Argument.AssertNotNull(keySourceParameters, nameof(keySourceParameters));

            KeyId = keyId;
            KeySourceParameters = keySourceParameters;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningKey"/>. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="keySourceParameters"> Defines the parameters for using customer key vault for Url Signing Key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UriSigningKey(string keyId, KeyVaultSigningKey keySourceParameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyId = keyId;
            KeySourceParameters = keySourceParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningKey"/> for deserialization. </summary>
        internal UriSigningKey()
        {
        }

        /// <summary> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </summary>
        public string KeyId { get; set; }
        /// <summary> Defines the parameters for using customer key vault for Url Signing Key. </summary>
        public KeyVaultSigningKey KeySourceParameters { get; set; }
    }
}
