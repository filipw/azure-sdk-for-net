// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountUsageMetricName : IUtf8JsonSerializable, IJsonModel<ServiceAccountUsageMetricName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAccountUsageMetricName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAccountUsageMetricName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountUsageMetricName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountUsageMetricName)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(LocalizedValue))
            {
                writer.WritePropertyName("localizedValue"u8);
                writer.WriteStringValue(LocalizedValue);
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

        ServiceAccountUsageMetricName IJsonModel<ServiceAccountUsageMetricName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountUsageMetricName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountUsageMetricName)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAccountUsageMetricName(document.RootElement, options);
        }

        internal static ServiceAccountUsageMetricName DeserializeServiceAccountUsageMetricName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            Optional<string> localizedValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"u8))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAccountUsageMetricName(value.Value, localizedValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAccountUsageMetricName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountUsageMetricName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountUsageMetricName)} does not support '{options.Format}' format.");
            }
        }

        ServiceAccountUsageMetricName IPersistableModel<ServiceAccountUsageMetricName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountUsageMetricName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAccountUsageMetricName(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountUsageMetricName)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAccountUsageMetricName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
