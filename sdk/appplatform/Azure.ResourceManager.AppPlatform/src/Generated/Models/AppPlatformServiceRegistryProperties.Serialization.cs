// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceRegistryProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformServiceRegistryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformServiceRegistryProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformServiceRegistryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceRegistryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ResourceRequests != null)
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests);
            }
            if (options.Format != "W" && !(Instances is ChangeTrackingList<AppPlatformServiceRegistryInstance> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        AppPlatformServiceRegistryProperties IJsonModel<AppPlatformServiceRegistryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceRegistryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformServiceRegistryProperties(document.RootElement, options);
        }

        internal static AppPlatformServiceRegistryProperties DeserializeAppPlatformServiceRegistryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AppPlatformServiceRegistryProvisioningState? provisioningState = default;
            AppPlatformServiceRegistryResourceRequirements resourceRequests = default;
            IReadOnlyList<AppPlatformServiceRegistryInstance> instances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformServiceRegistryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformServiceRegistryResourceRequirements.DeserializeAppPlatformServiceRegistryResourceRequirements(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRegistryInstance> array = new List<AppPlatformServiceRegistryInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRegistryInstance.DeserializeAppPlatformServiceRegistryInstance(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformServiceRegistryProperties(provisioningState, resourceRequests, instances ?? new ChangeTrackingList<AppPlatformServiceRegistryInstance>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformServiceRegistryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceRegistryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformServiceRegistryProperties IPersistableModel<AppPlatformServiceRegistryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceRegistryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformServiceRegistryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformServiceRegistryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
