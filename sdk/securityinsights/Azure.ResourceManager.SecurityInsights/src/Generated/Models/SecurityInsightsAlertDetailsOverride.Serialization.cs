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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlertDetailsOverride : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAlertDetailsOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAlertDetailsOverride>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsAlertDetailsOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AlertDisplayNameFormat))
            {
                writer.WritePropertyName("alertDisplayNameFormat"u8);
                writer.WriteStringValue(AlertDisplayNameFormat);
            }
            if (Optional.IsDefined(AlertDescriptionFormat))
            {
                writer.WritePropertyName("alertDescriptionFormat"u8);
                writer.WriteStringValue(AlertDescriptionFormat);
            }
            if (Optional.IsDefined(AlertTacticsColumnName))
            {
                writer.WritePropertyName("alertTacticsColumnName"u8);
                writer.WriteStringValue(AlertTacticsColumnName);
            }
            if (Optional.IsDefined(AlertSeverityColumnName))
            {
                writer.WritePropertyName("alertSeverityColumnName"u8);
                writer.WriteStringValue(AlertSeverityColumnName);
            }
            if (Optional.IsCollectionDefined(AlertDynamicProperties))
            {
                writer.WritePropertyName("alertDynamicProperties"u8);
                writer.WriteStartArray();
                foreach (var item in AlertDynamicProperties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        SecurityInsightsAlertDetailsOverride IJsonModel<SecurityInsightsAlertDetailsOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAlertDetailsOverride(document.RootElement, options);
        }

        internal static SecurityInsightsAlertDetailsOverride DeserializeSecurityInsightsAlertDetailsOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string alertDisplayNameFormat = default;
            string alertDescriptionFormat = default;
            string alertTacticsColumnName = default;
            string alertSeverityColumnName = default;
            IList<SecurityInsightsAlertPropertyMapping> alertDynamicProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertDisplayNameFormat"u8))
                {
                    alertDisplayNameFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertDescriptionFormat"u8))
                {
                    alertDescriptionFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertTacticsColumnName"u8))
                {
                    alertTacticsColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertSeverityColumnName"u8))
                {
                    alertSeverityColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertDynamicProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAlertPropertyMapping> array = new List<SecurityInsightsAlertPropertyMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsAlertPropertyMapping.DeserializeSecurityInsightsAlertPropertyMapping(item, options));
                    }
                    alertDynamicProperties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityInsightsAlertDetailsOverride(
                alertDisplayNameFormat,
                alertDescriptionFormat,
                alertTacticsColumnName,
                alertSeverityColumnName,
                alertDynamicProperties ?? new ChangeTrackingList<SecurityInsightsAlertPropertyMapping>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertDisplayNameFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertDisplayNameFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertDisplayNameFormat))
                {
                    builder.Append("  alertDisplayNameFormat: ");
                    if (AlertDisplayNameFormat.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AlertDisplayNameFormat}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AlertDisplayNameFormat}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertDescriptionFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertDescriptionFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertDescriptionFormat))
                {
                    builder.Append("  alertDescriptionFormat: ");
                    if (AlertDescriptionFormat.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AlertDescriptionFormat}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AlertDescriptionFormat}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertTacticsColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertTacticsColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertTacticsColumnName))
                {
                    builder.Append("  alertTacticsColumnName: ");
                    if (AlertTacticsColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AlertTacticsColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AlertTacticsColumnName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertSeverityColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertSeverityColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertSeverityColumnName))
                {
                    builder.Append("  alertSeverityColumnName: ");
                    if (AlertSeverityColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AlertSeverityColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AlertSeverityColumnName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertDynamicProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertDynamicProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlertDynamicProperties))
                {
                    if (AlertDynamicProperties.Any())
                    {
                        builder.Append("  alertDynamicProperties: ");
                        builder.AppendLine("[");
                        foreach (var item in AlertDynamicProperties)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  alertDynamicProperties: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsAlertDetailsOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsAlertDetailsOverride IPersistableModel<SecurityInsightsAlertDetailsOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsAlertDetailsOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAlertDetailsOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
