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

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateDetectionOptions : IUtf8JsonSerializable, IJsonModel<UnivariateDetectionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnivariateDetectionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UnivariateDetectionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateDetectionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("series"u8);
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Granularity.HasValue)
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (CustomInterval.HasValue)
            {
                writer.WritePropertyName("customInterval"u8);
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Period.HasValue)
            {
                writer.WritePropertyName("period"u8);
                writer.WriteNumberValue(Period.Value);
            }
            if (MaxAnomalyRatio.HasValue)
            {
                writer.WritePropertyName("maxAnomalyRatio"u8);
                writer.WriteNumberValue(MaxAnomalyRatio.Value);
            }
            if (Sensitivity.HasValue)
            {
                writer.WritePropertyName("sensitivity"u8);
                writer.WriteNumberValue(Sensitivity.Value);
            }
            if (ImputeMode.HasValue)
            {
                writer.WritePropertyName("imputeMode"u8);
                writer.WriteStringValue(ImputeMode.Value.ToString());
            }
            if (ImputeFixedValue.HasValue)
            {
                writer.WritePropertyName("imputeFixedValue"u8);
                writer.WriteNumberValue(ImputeFixedValue.Value);
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

        UnivariateDetectionOptions IJsonModel<UnivariateDetectionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateDetectionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnivariateDetectionOptions(document.RootElement, options);
        }

        internal static UnivariateDetectionOptions DeserializeUnivariateDetectionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TimeSeriesPoint> series = default;
            TimeGranularity? granularity = default;
            int? customInterval = default;
            int? period = default;
            float? maxAnomalyRatio = default;
            int? sensitivity = default;
            ImputeMode? imputeMode = default;
            float? imputeFixedValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("series"u8))
                {
                    List<TimeSeriesPoint> array = new List<TimeSeriesPoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesPoint.DeserializeTimeSeriesPoint(item, options));
                    }
                    series = array;
                    continue;
                }
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new TimeGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxAnomalyRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAnomalyRatio = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sensitivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("imputeMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imputeMode = new ImputeMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imputeFixedValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imputeFixedValue = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnivariateDetectionOptions(
                series,
                granularity,
                customInterval,
                period,
                maxAnomalyRatio,
                sensitivity,
                imputeMode,
                imputeFixedValue,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnivariateDetectionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UnivariateDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        UnivariateDetectionOptions IPersistableModel<UnivariateDetectionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnivariateDetectionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UnivariateDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UnivariateDetectionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnivariateDetectionOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnivariateDetectionOptions(document.RootElement);
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
