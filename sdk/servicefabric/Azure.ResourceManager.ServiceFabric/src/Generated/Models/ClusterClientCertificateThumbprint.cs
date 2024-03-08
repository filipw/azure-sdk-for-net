// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the client certificate details using thumbprint. </summary>
    public partial class ClusterClientCertificateThumbprint
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

        /// <summary> Initializes a new instance of <see cref="ClusterClientCertificateThumbprint"/>. </summary>
        /// <param name="isAdmin"> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </param>
        /// <param name="certificateThumbprint"> The thumbprint of the client certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateThumbprint"/> is null. </exception>
        public ClusterClientCertificateThumbprint(bool isAdmin, BinaryData certificateThumbprint)
        {
            Argument.AssertNotNull(certificateThumbprint, nameof(certificateThumbprint));

            IsAdmin = isAdmin;
            CertificateThumbprint = certificateThumbprint;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterClientCertificateThumbprint"/>. </summary>
        /// <param name="isAdmin"> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </param>
        /// <param name="certificateThumbprint"> The thumbprint of the client certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterClientCertificateThumbprint(bool isAdmin, BinaryData certificateThumbprint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAdmin = isAdmin;
            CertificateThumbprint = certificateThumbprint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterClientCertificateThumbprint"/> for deserialization. </summary>
        internal ClusterClientCertificateThumbprint()
        {
        }

        /// <summary> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// The thumbprint of the client certificate.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData CertificateThumbprint { get; set; }
    }
}
