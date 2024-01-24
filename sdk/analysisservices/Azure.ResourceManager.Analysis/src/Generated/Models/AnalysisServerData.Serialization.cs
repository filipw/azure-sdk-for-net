// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Analysis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Analysis
{
    public partial class AnalysisServerData : IUtf8JsonSerializable, IJsonModel<AnalysisServerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisServerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalysisServerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisServerData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(AnalysisSku);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AsAdministrators))
            {
                writer.WritePropertyName("asAdministrators"u8);
                writer.WriteObjectValue(AsAdministrators);
            }
            if (Optional.IsDefined(BackupBlobContainerUri))
            {
                writer.WritePropertyName("backupBlobContainerUri"u8);
                writer.WriteStringValue(BackupBlobContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(GatewayDetails))
            {
                writer.WritePropertyName("gatewayDetails"u8);
                writer.WriteObjectValue(GatewayDetails);
            }
            if (Optional.IsDefined(IPv4FirewallSettings))
            {
                writer.WritePropertyName("ipV4FirewallSettings"u8);
                writer.WriteObjectValue(IPv4FirewallSettings);
            }
            if (Optional.IsDefined(QueryPoolConnectionMode))
            {
                writer.WritePropertyName("querypoolConnectionMode"u8);
                writer.WriteStringValue(QueryPoolConnectionMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(ManagedMode))
            {
                writer.WritePropertyName("managedMode"u8);
                writer.WriteNumberValue(ManagedMode.Value.ToSerialInt32());
            }
            if (Optional.IsDefined(ServerMonitorMode))
            {
                writer.WritePropertyName("serverMonitorMode"u8);
                writer.WriteNumberValue(ServerMonitorMode.Value.ToSerialInt32());
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ServerFullName))
            {
                writer.WritePropertyName("serverFullName"u8);
                writer.WriteStringValue(ServerFullName);
            }
            if (Optional.IsDefined(AnalysisServerSku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(AnalysisServerSku);
            }
            writer.WriteEndObject();
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

        AnalysisServerData IJsonModel<AnalysisServerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisServerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisServerData(document.RootElement, options);
        }

        internal static AnalysisServerData DeserializeAnalysisServerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AnalysisResourceSku sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ServerAdministrators> asAdministrators = default;
            Optional<Uri> backupBlobContainerUri = default;
            Optional<AnalysisGatewayDetails> gatewayDetails = default;
            Optional<AnalysisIPv4FirewallSettings> ipV4FirewallSettings = default;
            Optional<AnalysisConnectionMode> querypoolConnectionMode = default;
            Optional<AnalysisManagedMode> managedMode = default;
            Optional<ServerMonitorMode> serverMonitorMode = default;
            Optional<AnalysisState> state = default;
            Optional<AnalysisProvisioningState> provisioningState = default;
            Optional<string> serverFullName = default;
            Optional<AnalysisResourceSku> sku0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AnalysisResourceSku.DeserializeAnalysisResourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("asAdministrators"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asAdministrators = ServerAdministrators.DeserializeServerAdministrators(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backupBlobContainerUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupBlobContainerUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayDetails = AnalysisGatewayDetails.DeserializeAnalysisGatewayDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipV4FirewallSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipV4FirewallSettings = AnalysisIPv4FirewallSettings.DeserializeAnalysisIPv4FirewallSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("querypoolConnectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            querypoolConnectionMode = property0.Value.GetString().ToAnalysisConnectionMode();
                            continue;
                        }
                        if (property0.NameEquals("managedMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedMode = new AnalysisManagedMode(property0.Value.GetInt32());
                            continue;
                        }
                        if (property0.NameEquals("serverMonitorMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverMonitorMode = new ServerMonitorMode(property0.Value.GetInt32());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new AnalysisState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AnalysisProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serverFullName"u8))
                        {
                            serverFullName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku0 = AnalysisResourceSku.DeserializeAnalysisResourceSku(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalysisServerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, asAdministrators.Value, backupBlobContainerUri.Value, gatewayDetails.Value, ipV4FirewallSettings.Value, Optional.ToNullable(querypoolConnectionMode), Optional.ToNullable(managedMode), Optional.ToNullable(serverMonitorMode), Optional.ToNullable(state), Optional.ToNullable(provisioningState), serverFullName.Value, sku0.Value, sku, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalysisServerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisServerData)} does not support '{options.Format}' format.");
            }
        }

        AnalysisServerData IPersistableModel<AnalysisServerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalysisServerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisServerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisServerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
