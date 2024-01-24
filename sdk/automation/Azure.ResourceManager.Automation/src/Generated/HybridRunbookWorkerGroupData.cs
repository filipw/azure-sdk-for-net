// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the HybridRunbookWorkerGroup data model.
    /// Definition of hybrid runbook worker group.
    /// </summary>
    public partial class HybridRunbookWorkerGroupData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="HybridRunbookWorkerGroupData"/>. </summary>
        public HybridRunbookWorkerGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridRunbookWorkerGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupType"> Type of the HybridWorkerGroup. </param>
        /// <param name="credential"> Sets the credential of a worker group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridRunbookWorkerGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, HybridWorkerGroup? groupType, RunAsCredentialAssociationProperty credential, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            GroupType = groupType;
            Credential = credential;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the HybridWorkerGroup. </summary>
        public HybridWorkerGroup? GroupType { get; set; }
        /// <summary> Sets the credential of a worker group. </summary>
        internal RunAsCredentialAssociationProperty Credential { get; set; }
        /// <summary> Gets or sets the name of the credential. </summary>
        public string CredentialName
        {
            get => Credential is null ? default : Credential.Name;
            set
            {
                if (Credential is null)
                    Credential = new RunAsCredentialAssociationProperty();
                Credential.Name = value;
            }
        }
    }
}
