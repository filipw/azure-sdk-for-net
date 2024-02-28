// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationUsage : IUtf8JsonSerializable, IJsonModel<AutomationUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationUsage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (CurrentValue.HasValue)
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (Limit.HasValue)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (ThrottleStatus != null)
            {
                writer.WritePropertyName("throttleStatus"u8);
                writer.WriteStringValue(ThrottleStatus);
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

        AutomationUsage IJsonModel<AutomationUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationUsage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationUsage(document.RootElement, options);
        }

        internal static AutomationUsage DeserializeAutomationUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            AutomationUsageCounterName name = default;
            string unit = default;
            double? currentValue = default;
            long? limit = default;
            string throttleStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = AutomationUsageCounterName.DeserializeAutomationUsageCounterName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throttleStatus"u8))
                {
                    throttleStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationUsage(
                id,
                name,
                unit,
                currentValue,
                limit,
                throttleStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationUsage)} does not support '{options.Format}' format.");
            }
        }

        AutomationUsage IPersistableModel<AutomationUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationUsage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
