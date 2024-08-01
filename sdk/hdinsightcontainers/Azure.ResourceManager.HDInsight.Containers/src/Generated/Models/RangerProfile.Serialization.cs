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
    public partial class RangerProfile : IUtf8JsonSerializable, IJsonModel<RangerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RangerProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RangerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangerProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rangerAdmin"u8);
            writer.WriteObjectValue(RangerAdmin, options);
            if (Optional.IsDefined(RangerAudit))
            {
                writer.WritePropertyName("rangerAudit"u8);
                writer.WriteObjectValue(RangerAudit, options);
            }
            writer.WritePropertyName("rangerUsersync"u8);
            writer.WriteObjectValue(RangerUsersync, options);
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

        RangerProfile IJsonModel<RangerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangerProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRangerProfile(document.RootElement, options);
        }

        internal static RangerProfile DeserializeRangerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RangerAdminSpec rangerAdmin = default;
            RangerAuditSpec rangerAudit = default;
            RangerUsersyncSpec rangerUsersync = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rangerAdmin"u8))
                {
                    rangerAdmin = RangerAdminSpec.DeserializeRangerAdminSpec(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerAudit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rangerAudit = RangerAuditSpec.DeserializeRangerAuditSpec(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerUsersync"u8))
                {
                    rangerUsersync = RangerUsersyncSpec.DeserializeRangerUsersyncSpec(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RangerProfile(rangerAdmin, rangerAudit, rangerUsersync, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RangerAdmin), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rangerAdmin: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RangerAdmin))
                {
                    builder.Append("  rangerAdmin: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RangerAdmin, options, 2, false, "  rangerAdmin: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("RangerAuditStorageAccount", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rangerAudit: ");
                builder.AppendLine("{");
                builder.Append("    storageAccount: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(RangerAudit))
                {
                    builder.Append("  rangerAudit: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RangerAudit, options, 2, false, "  rangerAudit: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RangerUsersync), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rangerUsersync: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RangerUsersync))
                {
                    builder.Append("  rangerUsersync: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RangerUsersync, options, 2, false, "  rangerUsersync: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RangerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RangerProfile)} does not support writing '{options.Format}' format.");
            }
        }

        RangerProfile IPersistableModel<RangerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRangerProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RangerProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RangerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
