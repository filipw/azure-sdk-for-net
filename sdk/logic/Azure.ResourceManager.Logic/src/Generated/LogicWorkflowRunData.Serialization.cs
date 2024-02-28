// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class LogicWorkflowRunData : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunData)} does not support '{format}' format.");
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
            if (options.Format != "W" && WaitEndOn.HasValue)
            {
                writer.WritePropertyName("waitEndTime"u8);
                writer.WriteStringValue(WaitEndOn.Value, "O");
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && EndOn.HasValue)
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Error);
#else
                using (JsonDocument document = JsonDocument.Parse(Error))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && CorrelationId != null)
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Correlation != null)
            {
                writer.WritePropertyName("correlation"u8);
                writer.WriteObjectValue(Correlation);
            }
            if (options.Format != "W" && Workflow != null)
            {
                writer.WritePropertyName("workflow"u8);
                writer.WriteObjectValue(Workflow);
            }
            if (options.Format != "W" && Trigger != null)
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteObjectValue(Trigger);
            }
            if (options.Format != "W" && !(Outputs is ChangeTrackingDictionary<string, LogicWorkflowOutputParameterInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartObject();
                foreach (var item in Outputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Response != null)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response);
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

        LogicWorkflowRunData IJsonModel<LogicWorkflowRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunData(document.RootElement, options);
        }

        internal static LogicWorkflowRunData DeserializeLogicWorkflowRunData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? waitEndTime = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            LogicWorkflowStatus? status = default;
            string code = default;
            BinaryData error = default;
            string correlationId = default;
            Correlation correlation = default;
            LogicResourceReference workflow = default;
            LogicWorkflowRunTrigger trigger = default;
            IReadOnlyDictionary<string, LogicWorkflowOutputParameterInfo> outputs = default;
            LogicWorkflowRunTrigger response = default;
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
                        if (property0.NameEquals("waitEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            waitEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new LogicWorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("correlationId"u8))
                        {
                            correlationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            correlation = Correlation.DeserializeCorrelation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("workflow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workflow = LogicResourceReference.DeserializeLogicResourceReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("trigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trigger = LogicWorkflowRunTrigger.DeserializeLogicWorkflowRunTrigger(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, LogicWorkflowOutputParameterInfo> dictionary = new Dictionary<string, LogicWorkflowOutputParameterInfo>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, LogicWorkflowOutputParameterInfo.DeserializeLogicWorkflowOutputParameterInfo(property1.Value, options));
                            }
                            outputs = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("response"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            response = LogicWorkflowRunTrigger.DeserializeLogicWorkflowRunTrigger(property0.Value, options);
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
            return new LogicWorkflowRunData(
                id,
                name,
                type,
                systemData,
                waitEndTime,
                startTime,
                endTime,
                status,
                code,
                error,
                correlationId,
                correlation,
                workflow,
                trigger,
                outputs ?? new ChangeTrackingDictionary<string, LogicWorkflowOutputParameterInfo>(),
                response,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRunData)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowRunData IPersistableModel<LogicWorkflowRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRunData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
