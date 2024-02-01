// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxPool : IUtf8JsonSerializable, IJsonModel<DevBoxPool>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevBoxPool>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevBoxPool>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevBoxPool)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile);
            }
            if (Optional.IsDefined(HibernateSupport))
            {
                writer.WritePropertyName("hibernateSupport"u8);
                writer.WriteStringValue(HibernateSupport.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference"u8);
                writer.WriteObjectValue(ImageReference);
            }
            if (Optional.IsDefined(LocalAdministratorStatus))
            {
                writer.WritePropertyName("localAdministrator"u8);
                writer.WriteStringValue(LocalAdministratorStatus.Value.ToString());
            }
            if (Optional.IsDefined(StopOnDisconnect))
            {
                writer.WritePropertyName("stopOnDisconnect"u8);
                writer.WriteObjectValue(StopOnDisconnect);
            }
            writer.WritePropertyName("healthStatus"u8);
            writer.WriteStringValue(HealthStatus.ToString());
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

        DevBoxPool IJsonModel<DevBoxPool>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevBoxPool)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevBoxPool(document.RootElement, options);
        }

        internal static DevBoxPool DeserializeDevBoxPool(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AzureLocation location = default;
            Optional<DevBoxOSType> osType = default;
            Optional<DevBoxHardwareProfile> hardwareProfile = default;
            Optional<HibernateSupport> hibernateSupport = default;
            Optional<DevBoxStorageProfile> storageProfile = default;
            Optional<DevBoxImageReference> imageReference = default;
            Optional<LocalAdministratorStatus> localAdministrator = default;
            Optional<StopOnDisconnectConfiguration> stopOnDisconnect = default;
            PoolHealthStatus healthStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new DevBoxOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hardwareProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareProfile = DevBoxHardwareProfile.DeserializeDevBoxHardwareProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("hibernateSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hibernateSupport = new HibernateSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = DevBoxStorageProfile.DeserializeDevBoxStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = DevBoxImageReference.DeserializeDevBoxImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("localAdministrator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localAdministrator = new LocalAdministratorStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopOnDisconnect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopOnDisconnect = StopOnDisconnectConfiguration.DeserializeStopOnDisconnectConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = new PoolHealthStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevBoxPool(name, location, Optional.ToNullable(osType), hardwareProfile.Value, Optional.ToNullable(hibernateSupport), storageProfile.Value, imageReference.Value, Optional.ToNullable(localAdministrator), stopOnDisconnect.Value, healthStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevBoxPool>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevBoxPool)} does not support '{options.Format}' format.");
            }
        }

        DevBoxPool IPersistableModel<DevBoxPool>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevBoxPool(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevBoxPool)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevBoxPool>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DevBoxPool FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDevBoxPool(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
