// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class ConsumptionEndpointsProperties : IUtf8JsonSerializable, IJsonModel<ConsumptionEndpointsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionEndpointsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionEndpointsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEndpointsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionEndpointsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && IngestionUri != null)
            {
                writer.WritePropertyName("ingestionUrl"u8);
                writer.WriteStringValue(IngestionUri.AbsoluteUri);
            }
            if (options.Format != "W" && IngestionResourceId != null)
            {
                writer.WritePropertyName("ingestionResourceId"u8);
                writer.WriteStringValue(IngestionResourceId);
            }
            if (options.Format != "W" && FileAccessUri != null)
            {
                writer.WritePropertyName("fileAccessUrl"u8);
                writer.WriteStringValue(FileAccessUri.AbsoluteUri);
            }
            if (options.Format != "W" && FileAccessResourceId != null)
            {
                writer.WritePropertyName("fileAccessResourceId"u8);
                writer.WriteStringValue(FileAccessResourceId);
            }
            if (options.Format != "W" && QueryUri != null)
            {
                writer.WritePropertyName("queryUrl"u8);
                writer.WriteStringValue(QueryUri.AbsoluteUri);
            }
            if (options.Format != "W" && QueryResourceId != null)
            {
                writer.WritePropertyName("queryResourceId"u8);
                writer.WriteStringValue(QueryResourceId);
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

        ConsumptionEndpointsProperties IJsonModel<ConsumptionEndpointsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEndpointsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionEndpointsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionEndpointsProperties(document.RootElement, options);
        }

        internal static ConsumptionEndpointsProperties DeserializeConsumptionEndpointsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri ingestionUrl = default;
            ResourceIdentifier ingestionResourceId = default;
            Uri fileAccessUrl = default;
            ResourceIdentifier fileAccessResourceId = default;
            Uri queryUrl = default;
            ResourceIdentifier queryResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileAccessUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileAccessUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileAccessResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileAccessResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionEndpointsProperties(
                ingestionUrl,
                ingestionResourceId,
                fileAccessUrl,
                fileAccessResourceId,
                queryUrl,
                queryResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionEndpointsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEndpointsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionEndpointsProperties)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionEndpointsProperties IPersistableModel<ConsumptionEndpointsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEndpointsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionEndpointsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionEndpointsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionEndpointsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
