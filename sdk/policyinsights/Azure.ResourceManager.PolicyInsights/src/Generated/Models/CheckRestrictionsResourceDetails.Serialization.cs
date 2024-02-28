// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class CheckRestrictionsResourceDetails : IUtf8JsonSerializable, IJsonModel<CheckRestrictionsResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckRestrictionsResourceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CheckRestrictionsResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckRestrictionsResourceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceContent"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResourceContent);
#else
            using (JsonDocument document = JsonDocument.Parse(ResourceContent))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (ApiVersion != null)
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
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

        CheckRestrictionsResourceDetails IJsonModel<CheckRestrictionsResourceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckRestrictionsResourceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckRestrictionsResourceDetails(document.RootElement, options);
        }

        internal static CheckRestrictionsResourceDetails DeserializeCheckRestrictionsResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData resourceContent = default;
            string apiVersion = default;
            string scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceContent"u8))
                {
                    resourceContent = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CheckRestrictionsResourceDetails(resourceContent, apiVersion, scope, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckRestrictionsResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckRestrictionsResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        CheckRestrictionsResourceDetails IPersistableModel<CheckRestrictionsResourceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckRestrictionsResourceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckRestrictionsResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckRestrictionsResourceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
