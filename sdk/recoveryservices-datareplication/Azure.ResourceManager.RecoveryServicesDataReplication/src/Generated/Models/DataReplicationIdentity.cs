// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Identity model. </summary>
    public partial class DataReplicationIdentity
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

        /// <summary> Initializes a new instance of <see cref="DataReplicationIdentity"/>. </summary>
        /// <param name="tenantId"> Gets or sets the tenant Id of the SPN with which Dra communicates to service. </param>
        /// <param name="applicationId">
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </param>
        /// <param name="objectId"> Gets or sets the object Id of the SPN with which Dra communicates to service. </param>
        /// <param name="audience"> Gets or sets the audience of the SPN with which Dra communicates to service. </param>
        /// <param name="aadAuthority"> Gets or sets the authority of the SPN with which Dra communicates to service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/>, <paramref name="objectId"/>, <paramref name="audience"/> or <paramref name="aadAuthority"/> is null. </exception>
        public DataReplicationIdentity(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority)
        {
            Argument.AssertNotNull(applicationId, nameof(applicationId));
            Argument.AssertNotNull(objectId, nameof(objectId));
            Argument.AssertNotNull(audience, nameof(audience));
            Argument.AssertNotNull(aadAuthority, nameof(aadAuthority));

            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationIdentity"/>. </summary>
        /// <param name="tenantId"> Gets or sets the tenant Id of the SPN with which Dra communicates to service. </param>
        /// <param name="applicationId">
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </param>
        /// <param name="objectId"> Gets or sets the object Id of the SPN with which Dra communicates to service. </param>
        /// <param name="audience"> Gets or sets the audience of the SPN with which Dra communicates to service. </param>
        /// <param name="aadAuthority"> Gets or sets the authority of the SPN with which Dra communicates to service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationIdentity(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationIdentity"/> for deserialization. </summary>
        internal DataReplicationIdentity()
        {
        }

        /// <summary> Gets or sets the tenant Id of the SPN with which Dra communicates to service. </summary>
        public Guid TenantId { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary> Gets or sets the object Id of the SPN with which Dra communicates to service. </summary>
        public string ObjectId { get; set; }
        /// <summary> Gets or sets the audience of the SPN with which Dra communicates to service. </summary>
        public string Audience { get; set; }
        /// <summary> Gets or sets the authority of the SPN with which Dra communicates to service. </summary>
        public string AadAuthority { get; set; }
    }
}
