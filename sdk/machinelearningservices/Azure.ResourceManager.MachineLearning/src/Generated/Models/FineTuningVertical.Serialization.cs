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
    [PersistableModelProxy(typeof(UnknownFineTuningVertical))]
    public partial class FineTuningVertical : IUtf8JsonSerializable, IJsonModel<FineTuningVertical>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FineTuningVertical>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FineTuningVertical>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningVertical>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningVertical)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelProvider"u8);
            writer.WriteStringValue(ModelProvider.ToString());
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData, options);
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData, options);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            writer.WritePropertyName("model"u8);
            writer.WriteObjectValue(Model, options);
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

        FineTuningVertical IJsonModel<FineTuningVertical>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningVertical>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningVertical)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFineTuningVertical(document.RootElement, options);
        }

        internal static FineTuningVertical DeserializeFineTuningVertical(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("modelProvider", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureOpenAI": return AzureOpenAiFineTuning.DeserializeAzureOpenAiFineTuning(element, options);
                    case "Custom": return CustomModelFineTuning.DeserializeCustomModelFineTuning(element, options);
                }
            }
            return UnknownFineTuningVertical.DeserializeUnknownFineTuningVertical(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ModelProvider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  modelProvider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  modelProvider: ");
                builder.AppendLine($"'{ModelProvider.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TaskType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  taskType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  taskType: ");
                builder.AppendLine($"'{TaskType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrainingData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trainingData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrainingData))
                {
                    builder.Append("  trainingData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TrainingData, options, 2, false, "  trainingData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationData))
                {
                    builder.Append("  validationData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ValidationData, options, 2, false, "  validationData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Model), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  model: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Model))
                {
                    builder.Append("  model: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Model, options, 2, false, "  model: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FineTuningVertical>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningVertical>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FineTuningVertical)} does not support writing '{options.Format}' format.");
            }
        }

        FineTuningVertical IPersistableModel<FineTuningVertical>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningVertical>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFineTuningVertical(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FineTuningVertical)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FineTuningVertical>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
