// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class TargetConfidenceScoreLabel : IUtf8JsonSerializable, IJsonModel<TargetConfidenceScoreLabel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetConfidenceScoreLabel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TargetConfidenceScoreLabel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetConfidenceScoreLabel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetConfidenceScoreLabel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("positive"u8);
            writer.WriteNumberValue(Positive);
            writer.WritePropertyName("negative"u8);
            writer.WriteNumberValue(Negative);
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

        TargetConfidenceScoreLabel IJsonModel<TargetConfidenceScoreLabel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetConfidenceScoreLabel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetConfidenceScoreLabel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetConfidenceScoreLabel(document.RootElement, options);
        }

        internal static TargetConfidenceScoreLabel DeserializeTargetConfidenceScoreLabel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double positive = default;
            double negative = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("positive"u8))
                {
                    positive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("negative"u8))
                {
                    negative = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TargetConfidenceScoreLabel(positive, negative, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetConfidenceScoreLabel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetConfidenceScoreLabel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TargetConfidenceScoreLabel)} does not support writing '{options.Format}' format.");
            }
        }

        TargetConfidenceScoreLabel IPersistableModel<TargetConfidenceScoreLabel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetConfidenceScoreLabel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTargetConfidenceScoreLabel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetConfidenceScoreLabel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetConfidenceScoreLabel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TargetConfidenceScoreLabel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTargetConfidenceScoreLabel(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
