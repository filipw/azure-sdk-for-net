// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseEndpointsPropertiesItemsItem : IUtf8JsonSerializable, IJsonModel<ResourcesResponseEndpointsPropertiesItemsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourcesResponseEndpointsPropertiesItemsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourcesResponseEndpointsPropertiesItemsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesResponseEndpointsPropertiesItemsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (EndpointId != null)
            {
                writer.WritePropertyName("endpointId"u8);
                writer.WriteStringValue(EndpointId);
            }
            if (History.HasValue)
            {
                writer.WritePropertyName("history"u8);
                writer.WriteBooleanValue(History.Value);
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

        ResourcesResponseEndpointsPropertiesItemsItem IJsonModel<ResourcesResponseEndpointsPropertiesItemsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesResponseEndpointsPropertiesItemsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesResponseEndpointsPropertiesItemsItem(document.RootElement, options);
        }

        internal static ResourcesResponseEndpointsPropertiesItemsItem DeserializeResourcesResponseEndpointsPropertiesItemsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string endpointId = default;
            bool? history = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointId"u8))
                {
                    endpointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    history = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourcesResponseEndpointsPropertiesItemsItem(id, name, endpointId, history, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourcesResponseEndpointsPropertiesItemsItem)} does not support '{options.Format}' format.");
            }
        }

        ResourcesResponseEndpointsPropertiesItemsItem IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourcesResponseEndpointsPropertiesItemsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourcesResponseEndpointsPropertiesItemsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourcesResponseEndpointsPropertiesItemsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
