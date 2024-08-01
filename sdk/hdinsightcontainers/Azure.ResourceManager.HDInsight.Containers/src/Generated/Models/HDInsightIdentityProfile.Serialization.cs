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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightIdentityProfile : IUtf8JsonSerializable, IJsonModel<HDInsightIdentityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightIdentityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightIdentityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("msiResourceId"u8);
            writer.WriteStringValue(MsiResourceId);
            writer.WritePropertyName("msiClientId"u8);
            writer.WriteStringValue(MsiClientId);
            writer.WritePropertyName("msiObjectId"u8);
            writer.WriteStringValue(MsiObjectId);
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

        HDInsightIdentityProfile IJsonModel<HDInsightIdentityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightIdentityProfile(document.RootElement, options);
        }

        internal static HDInsightIdentityProfile DeserializeHDInsightIdentityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier msiResourceId = default;
            string msiClientId = default;
            string msiObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("msiResourceId"u8))
                {
                    msiResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msiClientId"u8))
                {
                    msiClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("msiObjectId"u8))
                {
                    msiObjectId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightIdentityProfile(msiResourceId, msiClientId, msiObjectId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MsiResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  msiResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MsiResourceId))
                {
                    builder.Append("  msiResourceId: ");
                    builder.AppendLine($"'{MsiResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MsiClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  msiClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MsiClientId))
                {
                    builder.Append("  msiClientId: ");
                    if (MsiClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MsiClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MsiClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MsiObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  msiObjectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MsiObjectId))
                {
                    builder.Append("  msiObjectId: ");
                    if (MsiObjectId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MsiObjectId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MsiObjectId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HDInsightIdentityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightIdentityProfile IPersistableModel<HDInsightIdentityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightIdentityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightIdentityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
