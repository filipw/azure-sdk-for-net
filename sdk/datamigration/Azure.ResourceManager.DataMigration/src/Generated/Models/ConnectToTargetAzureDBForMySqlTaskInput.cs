// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure Database for MySQL and target server requirements. </summary>
    public partial class ConnectToTargetAzureDBForMySqlTaskInput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL server. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> or <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetAzureDBForMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL server. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL server. </param>
        /// <param name="isOfflineMigration"> Flag for whether or not the migration is offline. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetAzureDBForMySqlTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo, bool? isOfflineMigration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            IsOfflineMigration = isOfflineMigration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/> for deserialization. </summary>
        internal ConnectToTargetAzureDBForMySqlTaskInput()
        {
        }

        /// <summary> Connection information for source MySQL server. </summary>
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Connection information for target Azure Database for MySQL server. </summary>
        public MySqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Flag for whether or not the migration is offline. </summary>
        public bool? IsOfflineMigration { get; set; }
    }
}
