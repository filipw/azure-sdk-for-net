// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtMigrationDetails : IUtf8JsonSerializable, IJsonModel<VMwareCbtMigrationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtMigrationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtMigrationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtMigrationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtMigrationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && VMwareMachineId != null)
            {
                writer.WritePropertyName("vmwareMachineId"u8);
                writer.WriteStringValue(VMwareMachineId);
            }
            if (options.Format != "W" && OSType != null)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && OSName != null)
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && FirmwareType != null)
            {
                writer.WritePropertyName("firmwareType"u8);
                writer.WriteStringValue(FirmwareType);
            }
            if (options.Format != "W" && TargetGeneration != null)
            {
                writer.WritePropertyName("targetGeneration"u8);
                writer.WriteStringValue(TargetGeneration);
            }
            if (LicenseType != null)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (SqlServerLicenseType != null)
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType);
            }
            if (options.Format != "W" && DataMoverRunAsAccountId != null)
            {
                writer.WritePropertyName("dataMoverRunAsAccountId"u8);
                writer.WriteStringValue(DataMoverRunAsAccountId);
            }
            if (options.Format != "W" && SnapshotRunAsAccountId != null)
            {
                writer.WritePropertyName("snapshotRunAsAccountId"u8);
                writer.WriteStringValue(SnapshotRunAsAccountId);
            }
            if (options.Format != "W" && StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (TargetVmName != null)
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (TargetVmSize != null)
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (options.Format != "W" && TargetLocation != null)
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            if (TargetResourceGroupId != null)
            {
                writer.WritePropertyName("targetResourceGroupId"u8);
                writer.WriteStringValue(TargetResourceGroupId);
            }
            if (TargetAvailabilitySetId != null)
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (TargetAvailabilityZone != null)
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (TargetProximityPlacementGroupId != null)
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (ConfidentialVmKeyVaultId != null)
            {
                writer.WritePropertyName("confidentialVmKeyVaultId"u8);
                writer.WriteStringValue(ConfidentialVmKeyVaultId);
            }
            if (TargetVmSecurityProfile != null)
            {
                writer.WritePropertyName("targetVmSecurityProfile"u8);
                writer.WriteObjectValue(TargetVmSecurityProfile);
            }
            if (TargetBootDiagnosticsStorageAccountId != null)
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId"u8);
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (!(TargetVmTags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(ProtectedDisks is ChangeTrackingList<VMwareCbtProtectedDiskDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TargetNetworkId != null)
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (TestNetworkId != null)
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (!(VmNics is ChangeTrackingList<VMwareCbtNicDetails> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TargetNicTags is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && MigrationRecoveryPointId != null)
            {
                writer.WritePropertyName("migrationRecoveryPointId"u8);
                writer.WriteStringValue(MigrationRecoveryPointId);
            }
            if (options.Format != "W" && LastRecoveryPointReceived.HasValue)
            {
                writer.WritePropertyName("lastRecoveryPointReceived"u8);
                writer.WriteStringValue(LastRecoveryPointReceived.Value, "O");
            }
            if (options.Format != "W" && LastRecoveryPointId != null)
            {
                writer.WritePropertyName("lastRecoveryPointId"u8);
                writer.WriteStringValue(LastRecoveryPointId);
            }
            if (options.Format != "W" && InitialSeedingProgressPercentage.HasValue)
            {
                writer.WritePropertyName("initialSeedingProgressPercentage"u8);
                writer.WriteNumberValue(InitialSeedingProgressPercentage.Value);
            }
            if (options.Format != "W" && MigrationProgressPercentage.HasValue)
            {
                writer.WritePropertyName("migrationProgressPercentage"u8);
                writer.WriteNumberValue(MigrationProgressPercentage.Value);
            }
            if (options.Format != "W" && ResyncProgressPercentage.HasValue)
            {
                writer.WritePropertyName("resyncProgressPercentage"u8);
                writer.WriteNumberValue(ResyncProgressPercentage.Value);
            }
            if (options.Format != "W" && ResumeProgressPercentage.HasValue)
            {
                writer.WritePropertyName("resumeProgressPercentage"u8);
                writer.WriteNumberValue(ResumeProgressPercentage.Value);
            }
            if (options.Format != "W" && DeltaSyncProgressPercentage.HasValue)
            {
                writer.WritePropertyName("deltaSyncProgressPercentage"u8);
                writer.WriteNumberValue(DeltaSyncProgressPercentage.Value);
            }
            if (options.Format != "W" && IsCheckSumResyncCycle != null)
            {
                writer.WritePropertyName("isCheckSumResyncCycle"u8);
                writer.WriteStringValue(IsCheckSumResyncCycle);
            }
            if (options.Format != "W" && InitialSeedingRetryCount.HasValue)
            {
                writer.WritePropertyName("initialSeedingRetryCount"u8);
                writer.WriteNumberValue(InitialSeedingRetryCount.Value);
            }
            if (options.Format != "W" && ResyncRetryCount.HasValue)
            {
                writer.WritePropertyName("resyncRetryCount"u8);
                writer.WriteNumberValue(ResyncRetryCount.Value);
            }
            if (options.Format != "W" && ResumeRetryCount.HasValue)
            {
                writer.WritePropertyName("resumeRetryCount"u8);
                writer.WriteNumberValue(ResumeRetryCount.Value);
            }
            if (options.Format != "W" && DeltaSyncRetryCount.HasValue)
            {
                writer.WritePropertyName("deltaSyncRetryCount"u8);
                writer.WriteNumberValue(DeltaSyncRetryCount.Value);
            }
            if (options.Format != "W" && ResyncRequired != null)
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteStringValue(ResyncRequired);
            }
            if (options.Format != "W" && ResyncState.HasValue)
            {
                writer.WritePropertyName("resyncState"u8);
                writer.WriteStringValue(ResyncState.Value.ToString());
            }
            if (PerformAutoResync != null)
            {
                writer.WritePropertyName("performAutoResync"u8);
                writer.WriteStringValue(PerformAutoResync);
            }
            if (!(SeedDiskTags is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("seedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetDiskTags is ChangeTrackingDictionary<string, string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("targetDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(SupportedOSVersions is ChangeTrackingList<string> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("supportedOSVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedOSVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ApplianceMonitoringDetails != null)
            {
                writer.WritePropertyName("applianceMonitoringDetails"u8);
                writer.WriteObjectValue(ApplianceMonitoringDetails);
            }
            if (options.Format != "W" && GatewayOperationDetails != null)
            {
                writer.WritePropertyName("gatewayOperationDetails"u8);
                writer.WriteObjectValue(GatewayOperationDetails);
            }
            if (options.Format != "W" && OperationName != null)
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VMwareCbtMigrationDetails IJsonModel<VMwareCbtMigrationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtMigrationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtMigrationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtMigrationDetails(document.RootElement, options);
        }

        internal static VMwareCbtMigrationDetails DeserializeVMwareCbtMigrationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareMachineId = default;
            string osType = default;
            string osName = default;
            string firmwareType = default;
            string targetGeneration = default;
            string licenseType = default;
            string sqlServerLicenseType = default;
            ResourceIdentifier dataMoverRunAsAccountId = default;
            ResourceIdentifier snapshotRunAsAccountId = default;
            ResourceIdentifier storageAccountId = default;
            string targetVmName = default;
            string targetVmSize = default;
            string targetLocation = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier targetAvailabilitySetId = default;
            string targetAvailabilityZone = default;
            ResourceIdentifier targetProximityPlacementGroupId = default;
            ResourceIdentifier confidentialVmKeyVaultId = default;
            VMwareCbtSecurityProfileProperties targetVmSecurityProfile = default;
            ResourceIdentifier targetBootDiagnosticsStorageAccountId = default;
            IReadOnlyDictionary<string, string> targetVmTags = default;
            IReadOnlyList<VMwareCbtProtectedDiskDetails> protectedDisks = default;
            ResourceIdentifier targetNetworkId = default;
            ResourceIdentifier testNetworkId = default;
            IReadOnlyList<VMwareCbtNicDetails> vmNics = default;
            IReadOnlyDictionary<string, string> targetNicTags = default;
            ResourceIdentifier migrationRecoveryPointId = default;
            DateTimeOffset? lastRecoveryPointReceived = default;
            ResourceIdentifier lastRecoveryPointId = default;
            int? initialSeedingProgressPercentage = default;
            int? migrationProgressPercentage = default;
            int? resyncProgressPercentage = default;
            int? resumeProgressPercentage = default;
            int? deltaSyncProgressPercentage = default;
            string isCheckSumResyncCycle = default;
            long? initialSeedingRetryCount = default;
            long? resyncRetryCount = default;
            long? resumeRetryCount = default;
            long? deltaSyncRetryCount = default;
            string resyncRequired = default;
            SiteRecoveryResyncState? resyncState = default;
            string performAutoResync = default;
            IReadOnlyDictionary<string, string> seedDiskTags = default;
            IReadOnlyDictionary<string, string> targetDiskTags = default;
            IReadOnlyList<string> supportedOSVersions = default;
            ApplianceMonitoringDetails applianceMonitoringDetails = default;
            GatewayOperationDetails gatewayOperationDetails = default;
            string operationName = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareType"u8))
                {
                    firmwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetGeneration"u8))
                {
                    targetGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    sqlServerLicenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataMoverRunAsAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataMoverRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("snapshotRunAsAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("confidentialVmKeyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidentialVmKeyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSecurityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVmSecurityProfile = VMwareCbtSecurityProfileProperties.DeserializeVMwareCbtSecurityProfileProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetBootDiagnosticsStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBootDiagnosticsStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtProtectedDiskDetails> array = new List<VMwareCbtProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtProtectedDiskDetails.DeserializeVMwareCbtProtectedDiskDetails(item, options));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtNicDetails> array = new List<VMwareCbtNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtNicDetails.DeserializeVMwareCbtNicDetails(item, options));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("migrationRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialSeedingProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSeedingProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resumeProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deltaSyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaSyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isCheckSumResyncCycle"u8))
                {
                    isCheckSumResyncCycle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialSeedingRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSeedingRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resumeRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deltaSyncRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaSyncRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncState = new SiteRecoveryResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performAutoResync"u8))
                {
                    performAutoResync = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    seedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("supportedOSVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedOSVersions = array;
                    continue;
                }
                if (property.NameEquals("applianceMonitoringDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applianceMonitoringDetails = ApplianceMonitoringDetails.DeserializeApplianceMonitoringDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gatewayOperationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayOperationDetails = GatewayOperationDetails.DeserializeGatewayOperationDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtMigrationDetails(
                instanceType,
                serializedAdditionalRawData,
                vmwareMachineId,
                osType,
                osName,
                firmwareType,
                targetGeneration,
                licenseType,
                sqlServerLicenseType,
                dataMoverRunAsAccountId,
                snapshotRunAsAccountId,
                storageAccountId,
                targetVmName,
                targetVmSize,
                targetLocation,
                targetResourceGroupId,
                targetAvailabilitySetId,
                targetAvailabilityZone,
                targetProximityPlacementGroupId,
                confidentialVmKeyVaultId,
                targetVmSecurityProfile,
                targetBootDiagnosticsStorageAccountId,
                targetVmTags ?? new ChangeTrackingDictionary<string, string>(),
                protectedDisks ?? new ChangeTrackingList<VMwareCbtProtectedDiskDetails>(),
                targetNetworkId,
                testNetworkId,
                vmNics ?? new ChangeTrackingList<VMwareCbtNicDetails>(),
                targetNicTags ?? new ChangeTrackingDictionary<string, string>(),
                migrationRecoveryPointId,
                lastRecoveryPointReceived,
                lastRecoveryPointId,
                initialSeedingProgressPercentage,
                migrationProgressPercentage,
                resyncProgressPercentage,
                resumeProgressPercentage,
                deltaSyncProgressPercentage,
                isCheckSumResyncCycle,
                initialSeedingRetryCount,
                resyncRetryCount,
                resumeRetryCount,
                deltaSyncRetryCount,
                resyncRequired,
                resyncState,
                performAutoResync,
                seedDiskTags ?? new ChangeTrackingDictionary<string, string>(),
                targetDiskTags ?? new ChangeTrackingDictionary<string, string>(),
                supportedOSVersions ?? new ChangeTrackingList<string>(),
                applianceMonitoringDetails,
                gatewayOperationDetails,
                operationName);
        }

        BinaryData IPersistableModel<VMwareCbtMigrationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtMigrationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtMigrationDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtMigrationDetails IPersistableModel<VMwareCbtMigrationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtMigrationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtMigrationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtMigrationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtMigrationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
