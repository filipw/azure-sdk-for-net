// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningEncryptionKeyVaultProperties. </summary>
    public partial class MachineLearningEncryptionKeyVaultProperties
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/>. </summary>
        /// <param name="keyVaultArmId"> The ArmId of the keyVault where the customer owned encryption key is present. </param>
        /// <param name="keyIdentifier"> Key vault uri to access the encryption key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultArmId"/> or <paramref name="keyIdentifier"/> is null. </exception>
        public MachineLearningEncryptionKeyVaultProperties(ResourceIdentifier keyVaultArmId, string keyIdentifier)
        {
            Argument.AssertNotNull(keyVaultArmId, nameof(keyVaultArmId));
            Argument.AssertNotNull(keyIdentifier, nameof(keyIdentifier));

            KeyVaultArmId = keyVaultArmId;
            KeyIdentifier = keyIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/>. </summary>
        /// <param name="keyVaultArmId"> The ArmId of the keyVault where the customer owned encryption key is present. </param>
        /// <param name="keyIdentifier"> Key vault uri to access the encryption key. </param>
        /// <param name="identityClientId"> For future use - The client id of the identity which will be used to access key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEncryptionKeyVaultProperties(ResourceIdentifier keyVaultArmId, string keyIdentifier, string identityClientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyVaultArmId = keyVaultArmId;
            KeyIdentifier = keyIdentifier;
            IdentityClientId = identityClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/> for deserialization. </summary>
        internal MachineLearningEncryptionKeyVaultProperties()
        {
        }

        /// <summary> The ArmId of the keyVault where the customer owned encryption key is present. </summary>
        [WirePath("keyVaultArmId")]
        public ResourceIdentifier KeyVaultArmId { get; set; }
        /// <summary> Key vault uri to access the encryption key. </summary>
        [WirePath("keyIdentifier")]
        public string KeyIdentifier { get; set; }
        /// <summary> For future use - The client id of the identity which will be used to access key vault. </summary>
        [WirePath("identityClientId")]
        public string IdentityClientId { get; set; }
    }
}
