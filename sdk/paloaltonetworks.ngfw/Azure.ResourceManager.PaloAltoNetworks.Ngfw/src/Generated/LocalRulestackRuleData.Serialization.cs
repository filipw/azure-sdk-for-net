// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class LocalRulestackRuleData : IUtf8JsonSerializable, IJsonModel<LocalRulestackRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocalRulestackRuleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LocalRulestackRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalRulestackRuleData)} does not support '{format}' format.");
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
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("ruleName"u8);
            writer.WriteStringValue(RuleName);
            if (options.Format != "W" && Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (RuleState.HasValue)
            {
                writer.WritePropertyName("ruleState"u8);
                writer.WriteStringValue(RuleState.Value.ToString());
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (NegateSource.HasValue)
            {
                writer.WritePropertyName("negateSource"u8);
                writer.WriteStringValue(NegateSource.Value.ToString());
            }
            if (Destination != null)
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (NegateDestination.HasValue)
            {
                writer.WritePropertyName("negateDestination"u8);
                writer.WriteStringValue(NegateDestination.Value.ToString());
            }
            if (!(Applications is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("applications"u8);
                writer.WriteStartArray();
                foreach (var item in Applications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteObjectValue(Category);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol);
            }
            if (!(ProtocolPortList is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("protocolPortList"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolPortList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (InboundInspectionCertificate != null)
            {
                writer.WritePropertyName("inboundInspectionCertificate"u8);
                writer.WriteStringValue(InboundInspectionCertificate);
            }
            if (AuditComment != null)
            {
                writer.WritePropertyName("auditComment"u8);
                writer.WriteStringValue(AuditComment);
            }
            if (ActionType.HasValue)
            {
                writer.WritePropertyName("actionType"u8);
                writer.WriteStringValue(ActionType.Value.ToString());
            }
            if (EnableLogging.HasValue)
            {
                writer.WritePropertyName("enableLogging"u8);
                writer.WriteStringValue(EnableLogging.Value.ToString());
            }
            if (DecryptionRuleType.HasValue)
            {
                writer.WritePropertyName("decryptionRuleType"u8);
                writer.WriteStringValue(DecryptionRuleType.Value.ToString());
            }
            if (!(Tags is ChangeTrackingList<RulestackTagInfo> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        LocalRulestackRuleData IJsonModel<LocalRulestackRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalRulestackRuleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocalRulestackRuleData(document.RootElement, options);
        }

        internal static LocalRulestackRuleData DeserializeLocalRulestackRuleData(JsonElement element, ModelReaderWriterOptions options = null)
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
            ETag? etag = default;
            string ruleName = default;
            int? priority = default;
            string description = default;
            RulestackStateType? ruleState = default;
            SourceAddressInfo source = default;
            FirewallBooleanType? negateSource = default;
            DestinationAddressInfo destination = default;
            FirewallBooleanType? negateDestination = default;
            IList<string> applications = default;
            EdlMatchCategory category = default;
            string protocol = default;
            IList<string> protocolPortList = default;
            string inboundInspectionCertificate = default;
            string auditComment = default;
            RulestackActionType? actionType = default;
            RulestackStateType? enableLogging = default;
            DecryptionRuleType? decryptionRuleType = default;
            IList<RulestackTagInfo> tags = default;
            FirewallProvisioningState? provisioningState = default;
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
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ruleName"u8))
                        {
                            ruleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleState = new RulestackStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = SourceAddressInfo.DeserializeSourceAddressInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("negateSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            negateSource = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destination = DestinationAddressInfo.DeserializeDestinationAddressInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("negateDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            negateDestination = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            applications = array;
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = EdlMatchCategory.DeserializeEdlMatchCategory(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            protocol = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocolPortList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            protocolPortList = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundInspectionCertificate"u8))
                        {
                            inboundInspectionCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("auditComment"u8))
                        {
                            auditComment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actionType = new RulestackActionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableLogging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableLogging = new RulestackStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("decryptionRuleType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            decryptionRuleType = new DecryptionRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RulestackTagInfo> array = new List<RulestackTagInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RulestackTagInfo.DeserializeRulestackTagInfo(item, options));
                            }
                            tags = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FirewallProvisioningState(property0.Value.GetString());
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
            return new LocalRulestackRuleData(
                id,
                name,
                type,
                systemData,
                etag,
                ruleName,
                priority,
                description,
                ruleState,
                source,
                negateSource,
                destination,
                negateDestination,
                applications ?? new ChangeTrackingList<string>(),
                category,
                protocol,
                protocolPortList ?? new ChangeTrackingList<string>(),
                inboundInspectionCertificate,
                auditComment,
                actionType,
                enableLogging,
                decryptionRuleType,
                tags ?? new ChangeTrackingList<RulestackTagInfo>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LocalRulestackRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LocalRulestackRuleData)} does not support '{options.Format}' format.");
            }
        }

        LocalRulestackRuleData IPersistableModel<LocalRulestackRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocalRulestackRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LocalRulestackRuleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocalRulestackRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
