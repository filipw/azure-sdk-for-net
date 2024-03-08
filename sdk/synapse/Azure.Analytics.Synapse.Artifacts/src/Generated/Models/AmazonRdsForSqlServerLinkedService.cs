// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Amazon RDS for SQL Server linked service. </summary>
    public partial class AmazonRdsForSqlServerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AmazonRdsForSqlServerLinkedService"/>. </summary>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public AmazonRdsForSqlServerLinkedService(object connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
            Type = "AmazonRdsForSqlServer";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonRdsForSqlServerLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="userName"> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The on-premises Windows authentication password.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="alwaysEncryptedSettings"> Sql always encrypted properties. </param>
        internal AmazonRdsForSqlServerLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object userName, SecretBase password, object encryptedCredential, SqlAlwaysEncryptedProperties alwaysEncryptedSettings) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            AlwaysEncryptedSettings = alwaysEncryptedSettings;
            Type = type ?? "AmazonRdsForSqlServer";
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary>
        /// The on-premises Windows authentication password.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> Sql always encrypted properties. </summary>
        public SqlAlwaysEncryptedProperties AlwaysEncryptedSettings { get; set; }
    }
}
