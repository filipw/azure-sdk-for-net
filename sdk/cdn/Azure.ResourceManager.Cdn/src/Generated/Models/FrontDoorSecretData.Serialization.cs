// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorSecretData : IUtf8JsonSerializable, IJsonModel<FrontDoorSecretData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorSecretData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorSecretData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorSecretData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorSecretData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentStatus))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteStringValue(DeploymentStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Properties);
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

        FrontDoorSecretData IJsonModel<FrontDoorSecretData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorSecretData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorSecretData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorSecretData(document.RootElement, options);
        }

        internal static FrontDoorSecretData DeserializeFrontDoorSecretData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<FrontDoorProvisioningState> provisioningState = default;
            Optional<FrontDoorDeploymentStatus> deploymentStatus = default;
            Optional<string> profileName = default;
            Optional<FrontDoorSecretProperties> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FrontDoorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = new FrontDoorDeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("profileName"u8))
                        {
                            profileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parameters = FrontDoorSecretProperties.DeserializeFrontDoorSecretProperties(property0.Value);
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
            return new FrontDoorSecretData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus), profileName.Value, parameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorSecretData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorSecretData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorSecretData)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorSecretData IPersistableModel<FrontDoorSecretData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorSecretData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorSecretData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorSecretData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorSecretData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
