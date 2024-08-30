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
    internal partial class ManagedResourceGroupSettings : IUtf8JsonSerializable, IJsonModel<ManagedResourceGroupSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedResourceGroupSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedResourceGroupSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedResourceGroupSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedResourceGroupSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AssignedIdentities))
            {
                if (AssignedIdentities != null)
                {
                    writer.WritePropertyName("assignedIdentities"u8);
                    writer.WriteStartArray();
                    foreach (var item in AssignedIdentities)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("assignedIdentities");
                }
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

        ManagedResourceGroupSettings IJsonModel<ManagedResourceGroupSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedResourceGroupSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedResourceGroupSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedResourceGroupSettings(document.RootElement, options);
        }

        internal static ManagedResourceGroupSettings DeserializeManagedResourceGroupSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ManagedResourceGroupAssignedIdentities> assignedIdentities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignedIdentities = null;
                        continue;
                    }
                    List<ManagedResourceGroupAssignedIdentities> array = new List<ManagedResourceGroupAssignedIdentities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedResourceGroupAssignedIdentities.DeserializeManagedResourceGroupAssignedIdentities(item, options));
                    }
                    assignedIdentities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedResourceGroupSettings(assignedIdentities ?? new ChangeTrackingList<ManagedResourceGroupAssignedIdentities>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignedIdentities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  assignedIdentities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AssignedIdentities))
                {
                    if (AssignedIdentities.Any())
                    {
                        builder.Append("  assignedIdentities: ");
                        builder.AppendLine("[");
                        foreach (var item in AssignedIdentities)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  assignedIdentities: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedResourceGroupSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedResourceGroupSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedResourceGroupSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedResourceGroupSettings IPersistableModel<ManagedResourceGroupSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedResourceGroupSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedResourceGroupSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedResourceGroupSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedResourceGroupSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
