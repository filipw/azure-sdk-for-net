// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationCertificate data model.
    /// Definition of the certificate.
    /// </summary>
    public partial class AutomationCertificateData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateData"/>. </summary>
        public AutomationCertificateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintString"> Gets the thumbprint of the certificate. </param>
        /// <param name="expireOn"> Gets the expiry time of the certificate. </param>
        /// <param name="isExportable"> Gets the is exportable flag of the certificate. </param>
        /// <param name="createdOn"> Gets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string thumbprintString, DateTimeOffset? expireOn, bool? isExportable, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ThumbprintString = thumbprintString;
            ExpireOn = expireOn;
            IsExportable = isExportable;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the thumbprint of the certificate. </summary>
        public string ThumbprintString { get; }
        /// <summary> Gets the expiry time of the certificate. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Gets the is exportable flag of the certificate. </summary>
        public bool? IsExportable { get; }
        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
