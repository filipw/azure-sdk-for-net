// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class WebApplicationFirewallScrubbingRules : IUtf8JsonSerializable, IJsonModel<WebApplicationFirewallScrubbingRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationFirewallScrubbingRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebApplicationFirewallScrubbingRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallScrubbingRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallScrubbingRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable.ToString());
            writer.WritePropertyName("selectorMatchOperator"u8);
            writer.WriteStringValue(SelectorMatchOperator.ToString());
            if (Selector != null)
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteStringValue(Selector);
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        WebApplicationFirewallScrubbingRules IJsonModel<WebApplicationFirewallScrubbingRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallScrubbingRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallScrubbingRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallScrubbingRules(document.RootElement, options);
        }

        internal static WebApplicationFirewallScrubbingRules DeserializeWebApplicationFirewallScrubbingRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScrubbingRuleEntryMatchVariable matchVariable = default;
            ScrubbingRuleEntryMatchOperator selectorMatchOperator = default;
            string selector = default;
            ScrubbingRuleEntryState? state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = new ScrubbingRuleEntryMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"u8))
                {
                    selectorMatchOperator = new ScrubbingRuleEntryMatchOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ScrubbingRuleEntryState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebApplicationFirewallScrubbingRules(matchVariable, selectorMatchOperator, selector, state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationFirewallScrubbingRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallScrubbingRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallScrubbingRules)} does not support '{options.Format}' format.");
            }
        }

        WebApplicationFirewallScrubbingRules IPersistableModel<WebApplicationFirewallScrubbingRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallScrubbingRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationFirewallScrubbingRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallScrubbingRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationFirewallScrubbingRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
