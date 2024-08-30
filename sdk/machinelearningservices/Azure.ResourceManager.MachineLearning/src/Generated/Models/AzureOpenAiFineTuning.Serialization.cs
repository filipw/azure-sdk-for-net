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
    public partial class AzureOpenAiFineTuning : IUtf8JsonSerializable, IJsonModel<AzureOpenAiFineTuning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOpenAiFineTuning>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureOpenAiFineTuning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOpenAiFineTuning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOpenAiFineTuning)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HyperParameters))
            {
                if (HyperParameters != null)
                {
                    writer.WritePropertyName("hyperParameters"u8);
                    writer.WriteObjectValue(HyperParameters, options);
                }
                else
                {
                    writer.WriteNull("hyperParameters");
                }
            }
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

        AzureOpenAiFineTuning IJsonModel<AzureOpenAiFineTuning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOpenAiFineTuning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOpenAiFineTuning)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOpenAiFineTuning(document.RootElement, options);
        }

        internal static AzureOpenAiFineTuning DeserializeAzureOpenAiFineTuning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureOpenAiHyperParameters hyperParameters = default;
            ModelProvider modelProvider = default;
            FineTuningTaskType taskType = default;
            MachineLearningJobInput trainingData = default;
            MachineLearningJobInput validationData = default;
            MachineLearningFlowModelJobInput model = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hyperParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        hyperParameters = null;
                        continue;
                    }
                    hyperParameters = AzureOpenAiHyperParameters.DeserializeAzureOpenAiHyperParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelProvider"u8))
                {
                    modelProvider = new ModelProvider(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new FineTuningTaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningJobInput.DeserializeMachineLearningJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningJobInput.DeserializeMachineLearningJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = MachineLearningFlowModelJobInput.DeserializeMachineLearningFlowModelJobInput(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureOpenAiFineTuning(
                modelProvider,
                taskType,
                trainingData,
                validationData,
                model,
                serializedAdditionalRawData,
                hyperParameters);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HyperParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hyperParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HyperParameters))
                {
                    builder.Append("  hyperParameters: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HyperParameters, options, 2, false, "  hyperParameters: ");
                }
            }

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

        BinaryData IPersistableModel<AzureOpenAiFineTuning>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOpenAiFineTuning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AzureOpenAiFineTuning)} does not support writing '{options.Format}' format.");
            }
        }

        AzureOpenAiFineTuning IPersistableModel<AzureOpenAiFineTuning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOpenAiFineTuning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOpenAiFineTuning(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOpenAiFineTuning)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOpenAiFineTuning>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
