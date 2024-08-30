// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageSweepSettings : IUtf8JsonSerializable, IJsonModel<ImageSweepSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageSweepSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ImageSweepSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSweepSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EarlyTermination))
            {
                if (EarlyTermination != null)
                {
                    writer.WritePropertyName("earlyTermination"u8);
                    writer.WriteObjectValue(EarlyTermination, options);
                }
                else
                {
                    writer.WriteNull("earlyTermination");
                }
            }
            writer.WritePropertyName("samplingAlgorithm"u8);
            writer.WriteStringValue(SamplingAlgorithm.ToString());
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

        ImageSweepSettings IJsonModel<ImageSweepSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSweepSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageSweepSettings(document.RootElement, options);
        }

        internal static ImageSweepSettings DeserializeImageSweepSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningEarlyTerminationPolicy earlyTermination = default;
            SamplingAlgorithmType samplingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("earlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyTermination = null;
                        continue;
                    }
                    earlyTermination = MachineLearningEarlyTerminationPolicy.DeserializeMachineLearningEarlyTerminationPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("samplingAlgorithm"u8))
                {
                    samplingAlgorithm = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ImageSweepSettings(earlyTermination, samplingAlgorithm, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EarlyTermination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  earlyTermination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EarlyTermination))
                {
                    builder.Append("  earlyTermination: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EarlyTermination, options, 2, false, "  earlyTermination: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SamplingAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  samplingAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  samplingAlgorithm: ");
                builder.AppendLine($"'{SamplingAlgorithm.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ImageSweepSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSweepSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ImageSweepSettings IPersistableModel<ImageSweepSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSweepSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageSweepSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageSweepSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
