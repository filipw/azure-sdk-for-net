// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SalesforceV2Sink : IUtf8JsonSerializable, IJsonModel<SalesforceV2Sink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SalesforceV2Sink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SalesforceV2Sink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2Sink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SalesforceV2Sink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (WriteBehavior.HasValue)
            {
                writer.WritePropertyName("writeBehavior"u8);
                writer.WriteStringValue(WriteBehavior.Value.ToString());
            }
            if (ExternalIdFieldName != null)
            {
                writer.WritePropertyName("externalIdFieldName"u8);
                JsonSerializer.Serialize(writer, ExternalIdFieldName);
            }
            if (IgnoreNullValues != null)
            {
                writer.WritePropertyName("ignoreNullValues"u8);
                JsonSerializer.Serialize(writer, IgnoreNullValues);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (WriteBatchSize != null)
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (WriteBatchTimeout != null)
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (SinkRetryCount != null)
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (SinkRetryWait != null)
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SalesforceV2Sink IJsonModel<SalesforceV2Sink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2Sink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SalesforceV2Sink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSalesforceV2Sink(document.RootElement, options);
        }

        internal static SalesforceV2Sink DeserializeSalesforceV2Sink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SalesforceV2SinkWriteBehavior? writeBehavior = default;
            DataFactoryElement<string> externalIdFieldName = default;
            DataFactoryElement<bool> ignoreNullValues = default;
            string type = default;
            DataFactoryElement<int> writeBatchSize = default;
            DataFactoryElement<string> writeBatchTimeout = default;
            DataFactoryElement<int> sinkRetryCount = default;
            DataFactoryElement<string> sinkRetryWait = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBehavior = new SalesforceV2SinkWriteBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("externalIdFieldName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    externalIdFieldName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreNullValues = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SalesforceV2Sink(
                type,
                writeBatchSize,
                writeBatchTimeout,
                sinkRetryCount,
                sinkRetryWait,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                writeBehavior,
                externalIdFieldName,
                ignoreNullValues);
        }

        BinaryData IPersistableModel<SalesforceV2Sink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2Sink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SalesforceV2Sink)} does not support '{options.Format}' format.");
            }
        }

        SalesforceV2Sink IPersistableModel<SalesforceV2Sink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SalesforceV2Sink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSalesforceV2Sink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SalesforceV2Sink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SalesforceV2Sink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
