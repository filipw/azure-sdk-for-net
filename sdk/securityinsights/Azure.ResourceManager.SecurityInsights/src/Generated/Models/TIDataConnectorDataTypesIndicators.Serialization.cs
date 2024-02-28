// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class TIDataConnectorDataTypesIndicators : IUtf8JsonSerializable, IJsonModel<TIDataConnectorDataTypesIndicators>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TIDataConnectorDataTypesIndicators>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TIDataConnectorDataTypesIndicators>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TIDataConnectorDataTypesIndicators>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TIDataConnectorDataTypesIndicators)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        TIDataConnectorDataTypesIndicators IJsonModel<TIDataConnectorDataTypesIndicators>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TIDataConnectorDataTypesIndicators>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TIDataConnectorDataTypesIndicators)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTIDataConnectorDataTypesIndicators(document.RootElement, options);
        }

        internal static TIDataConnectorDataTypesIndicators DeserializeTIDataConnectorDataTypesIndicators(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsDataTypeConnectionState? state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityInsightsDataTypeConnectionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TIDataConnectorDataTypesIndicators(state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TIDataConnectorDataTypesIndicators>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TIDataConnectorDataTypesIndicators>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TIDataConnectorDataTypesIndicators)} does not support '{options.Format}' format.");
            }
        }

        TIDataConnectorDataTypesIndicators IPersistableModel<TIDataConnectorDataTypesIndicators>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TIDataConnectorDataTypesIndicators>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTIDataConnectorDataTypesIndicators(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TIDataConnectorDataTypesIndicators)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TIDataConnectorDataTypesIndicators>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
