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
    [PersistableModelProxy(typeof(UnknownJobOutput))]
    public partial class MachineLearningJobOutput : IUtf8JsonSerializable, IJsonModel<MachineLearningJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningJobOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
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

        MachineLearningJobOutput IJsonModel<MachineLearningJobOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobOutput(document.RootElement, options);
        }

        internal static MachineLearningJobOutput DeserializeMachineLearningJobOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobOutputType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "custom_model": return MachineLearningCustomModelJobOutput.DeserializeMachineLearningCustomModelJobOutput(element, options);
                    case "mlflow_model": return MachineLearningFlowModelJobOutput.DeserializeMachineLearningFlowModelJobOutput(element, options);
                    case "mltable": return MachineLearningTableJobOutput.DeserializeMachineLearningTableJobOutput(element, options);
                    case "triton_model": return MachineLearningTritonModelJobOutput.DeserializeMachineLearningTritonModelJobOutput(element, options);
                    case "uri_file": return MachineLearningUriFileJobOutput.DeserializeMachineLearningUriFileJobOutput(element, options);
                    case "uri_folder": return MachineLearningUriFolderJobOutput.DeserializeMachineLearningUriFolderJobOutput(element, options);
                }
            }
            return UnknownJobOutput.DeserializeUnknownJobOutput(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobOutputType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobOutputType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  jobOutputType: ");
                builder.AppendLine($"'{JobOutputType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningJobOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningJobOutput IPersistableModel<MachineLearningJobOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
