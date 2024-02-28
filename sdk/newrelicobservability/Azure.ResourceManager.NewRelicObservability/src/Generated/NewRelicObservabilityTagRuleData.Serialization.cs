// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    public partial class NewRelicObservabilityTagRuleData : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityTagRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityTagRuleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRelicObservabilityTagRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityTagRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityTagRuleData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (LogRules != null)
            {
                writer.WritePropertyName("logRules"u8);
                writer.WriteObjectValue(LogRules);
            }
            if (MetricRules != null)
            {
                writer.WritePropertyName("metricRules"u8);
                writer.WriteObjectValue(MetricRules);
            }
            writer.WriteEndObject();
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

        NewRelicObservabilityTagRuleData IJsonModel<NewRelicObservabilityTagRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityTagRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityTagRuleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityTagRuleData(document.RootElement, options);
        }

        internal static NewRelicObservabilityTagRuleData DeserializeNewRelicObservabilityTagRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            NewRelicProvisioningState? provisioningState = default;
            NewRelicObservabilityLogRules logRules = default;
            NewRelicObservabilityMetricRules metricRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NewRelicProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logRules = NewRelicObservabilityLogRules.DeserializeNewRelicObservabilityLogRules(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metricRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metricRules = NewRelicObservabilityMetricRules.DeserializeNewRelicObservabilityMetricRules(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicObservabilityTagRuleData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                logRules,
                metricRules,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicObservabilityTagRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityTagRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityTagRuleData)} does not support '{options.Format}' format.");
            }
        }

        NewRelicObservabilityTagRuleData IPersistableModel<NewRelicObservabilityTagRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityTagRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicObservabilityTagRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityTagRuleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityTagRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
