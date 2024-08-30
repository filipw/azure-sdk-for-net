// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Blob datastore configuration. </summary>
    public partial class MachineLearningAzureBlobDatastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureBlobDatastore"/>. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> is null. </exception>
        public MachineLearningAzureBlobDatastore(MachineLearningDatastoreCredentials credentials) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));

            DatastoreType = DatastoreType.AzureBlob;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureBlobDatastore"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="accountName"> Storage account name. </param>
        /// <param name="containerName"> Storage account container name. </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer's storage. </param>
        /// <param name="resourceGroup"> Azure Resource Group name. </param>
        /// <param name="subscriptionId"> Azure Subscription Id. </param>
        internal MachineLearningAzureBlobDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, string accountName, string containerName, string endpoint, string protocol, MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity, string resourceGroup, string subscriptionId) : base(description, properties, tags, serializedAdditionalRawData, credentials, datastoreType, isDefault)
        {
            AccountName = accountName;
            ContainerName = containerName;
            Endpoint = endpoint;
            Protocol = protocol;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            DatastoreType = datastoreType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureBlobDatastore"/> for deserialization. </summary>
        internal MachineLearningAzureBlobDatastore()
        {
        }

        /// <summary> Storage account name. </summary>
        [WirePath("accountName")]
        public string AccountName { get; set; }
        /// <summary> Storage account container name. </summary>
        [WirePath("containerName")]
        public string ContainerName { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        [WirePath("endpoint")]
        public string Endpoint { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        [WirePath("protocol")]
        public string Protocol { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer's storage. </summary>
        [WirePath("serviceDataAccessAuthIdentity")]
        public MachineLearningServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
        /// <summary> Azure Resource Group name. </summary>
        [WirePath("resourceGroup")]
        public string ResourceGroup { get; set; }
        /// <summary> Azure Subscription Id. </summary>
        [WirePath("subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}
