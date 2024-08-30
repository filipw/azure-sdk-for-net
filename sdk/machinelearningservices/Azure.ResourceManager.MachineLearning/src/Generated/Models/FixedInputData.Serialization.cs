// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FixedInputData : IUtf8JsonSerializable, IJsonModel<FixedInputData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FixedInputData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FixedInputData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FixedInputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FixedInputData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Columns))
            {
                if (Columns != null)
                {
                    writer.WritePropertyName("columns"u8);
                    writer.WriteStartObject();
                    foreach (var item in Columns)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("columns");
                }
            }
            if (Optional.IsDefined(DataContext))
            {
                if (DataContext != null)
                {
                    writer.WritePropertyName("dataContext"u8);
                    writer.WriteStringValue(DataContext);
                }
                else
                {
                    writer.WriteNull("dataContext");
                }
            }
            writer.WritePropertyName("inputDataType"u8);
            writer.WriteStringValue(InputDataType.ToString());
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
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

        FixedInputData IJsonModel<FixedInputData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FixedInputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FixedInputData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFixedInputData(document.RootElement, options);
        }

        internal static FixedInputData DeserializeFixedInputData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> columns = default;
            string dataContext = default;
            MonitoringInputDataType inputDataType = default;
            JobInputType jobInputType = default;
            Uri uri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        columns = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    columns = dictionary;
                    continue;
                }
                if (property.NameEquals("dataContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataContext = null;
                        continue;
                    }
                    dataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataType"u8))
                {
                    inputDataType = new MonitoringInputDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobInputType"u8))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FixedInputData(
                columns ?? new ChangeTrackingDictionary<string, string>(),
                dataContext,
                inputDataType,
                jobInputType,
                uri,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Columns), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  columns: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Columns))
                {
                    if (Columns.Any())
                    {
                        builder.Append("  columns: ");
                        builder.AppendLine("{");
                        foreach (var item in Columns)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataContext), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataContext: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataContext))
                {
                    builder.Append("  dataContext: ");
                    if (DataContext.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DataContext}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DataContext}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InputDataType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  inputDataType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  inputDataType: ");
                builder.AppendLine($"'{InputDataType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobInputType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobInputType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  jobInputType: ");
                builder.AppendLine($"'{JobInputType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  uri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uri))
                {
                    builder.Append("  uri: ");
                    builder.AppendLine($"'{Uri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FixedInputData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FixedInputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FixedInputData)} does not support writing '{options.Format}' format.");
            }
        }

        FixedInputData IPersistableModel<FixedInputData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FixedInputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFixedInputData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FixedInputData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FixedInputData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
