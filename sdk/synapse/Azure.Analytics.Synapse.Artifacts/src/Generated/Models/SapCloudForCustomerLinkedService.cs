// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for SAP Cloud for Customer. </summary>
    public partial class SapCloudForCustomerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerLinkedService"/>. </summary>
        /// <param name="url"> The URL of SAP Cloud for Customer OData API. For example, '[https://[tenantname].crm.ondemand.com/sap/c4c/odata/v1]'. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public SapCloudForCustomerLinkedService(object url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
            Type = "SapCloudForCustomer";
        }

        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="url"> The URL of SAP Cloud for Customer OData API. For example, '[https://[tenantname].crm.ondemand.com/sap/c4c/odata/v1]'. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The password for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Either encryptedCredential or username/password must be provided. Type: string (or Expression with resultType string). </param>
        internal SapCloudForCustomerLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, object username, SecretBase password, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SapCloudForCustomer";
        }

        /// <summary> The URL of SAP Cloud for Customer OData API. For example, '[https://[tenantname].crm.ondemand.com/sap/c4c/odata/v1]'. Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary> The username for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// The password for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Either encryptedCredential or username/password must be provided. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
