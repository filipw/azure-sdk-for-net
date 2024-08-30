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
    public partial class TextClassification : IUtf8JsonSerializable, IJsonModel<TextClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextClassification>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextClassification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextClassification)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    writer.WriteObjectValue(FeaturizationSettings, options);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    writer.WriteObjectValue(LimitSettings, options);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
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
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData, options);
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

        TextClassification IJsonModel<TextClassification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextClassification)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextClassification(document.RootElement, options);
        }

        internal static TextClassification DeserializeTextClassification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClassificationPrimaryMetric? primaryMetric = default;
            NlpVerticalFeaturizationSettings featurizationSettings = default;
            NlpVerticalLimitSettings limitSettings = default;
            MachineLearningTableJobInput validationData = default;
            MachineLearningLogVerbosity? logVerbosity = default;
            string targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ClassificationPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = NlpVerticalFeaturizationSettings.DeserializeNlpVerticalFeaturizationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = NlpVerticalLimitSettings.DeserializeNlpVerticalLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextClassification(
                logVerbosity,
                targetColumnName,
                taskType,
                trainingData,
                serializedAdditionalRawData,
                primaryMetric,
                featurizationSettings,
                limitSettings,
                validationData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryMetric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryMetric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryMetric))
                {
                    builder.Append("  primaryMetric: ");
                    builder.AppendLine($"'{PrimaryMetric.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("FeaturizationDatasetLanguage", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  featurizationSettings: ");
                builder.AppendLine("{");
                builder.Append("    datasetLanguage: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(FeaturizationSettings))
                {
                    builder.Append("  featurizationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, FeaturizationSettings, options, 2, false, "  featurizationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LimitSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  limitSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LimitSettings))
                {
                    builder.Append("  limitSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LimitSettings, options, 2, false, "  limitSettings: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogVerbosity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logVerbosity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogVerbosity))
                {
                    builder.Append("  logVerbosity: ");
                    builder.AppendLine($"'{LogVerbosity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetColumnName))
                {
                    builder.Append("  targetColumnName: ");
                    if (TargetColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetColumnName}'");
                    }
                }
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

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TextClassification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TextClassification)} does not support writing '{options.Format}' format.");
            }
        }

        TextClassification IPersistableModel<TextClassification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTextClassification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextClassification)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextClassification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
