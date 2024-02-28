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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SitePhpErrorLogFlag : IUtf8JsonSerializable, IJsonModel<SitePhpErrorLogFlag>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SitePhpErrorLogFlag>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SitePhpErrorLogFlag>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (LocalLogErrors != null)
            {
                writer.WritePropertyName("localLogErrors"u8);
                writer.WriteStringValue(LocalLogErrors);
            }
            if (MasterLogErrors != null)
            {
                writer.WritePropertyName("masterLogErrors"u8);
                writer.WriteStringValue(MasterLogErrors);
            }
            if (LocalLogErrorsMaxLength != null)
            {
                writer.WritePropertyName("localLogErrorsMaxLength"u8);
                writer.WriteStringValue(LocalLogErrorsMaxLength);
            }
            if (MasterLogErrorsMaxLength != null)
            {
                writer.WritePropertyName("masterLogErrorsMaxLength"u8);
                writer.WriteStringValue(MasterLogErrorsMaxLength);
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

        SitePhpErrorLogFlag IJsonModel<SitePhpErrorLogFlag>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSitePhpErrorLogFlag(document.RootElement, options);
        }

        internal static SitePhpErrorLogFlag DeserializeSitePhpErrorLogFlag(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string localLogErrors = default;
            string masterLogErrors = default;
            string localLogErrorsMaxLength = default;
            string masterLogErrorsMaxLength = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("localLogErrors"u8))
                        {
                            localLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrors"u8))
                        {
                            masterLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localLogErrorsMaxLength"u8))
                        {
                            localLogErrorsMaxLength = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrorsMaxLength"u8))
                        {
                            masterLogErrorsMaxLength = property0.Value.GetString();
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
            return new SitePhpErrorLogFlag(
                id,
                name,
                type,
                systemData,
                localLogErrors,
                masterLogErrors,
                localLogErrorsMaxLength,
                masterLogErrorsMaxLength,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SitePhpErrorLogFlag>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{options.Format}' format.");
            }
        }

        SitePhpErrorLogFlag IPersistableModel<SitePhpErrorLogFlag>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSitePhpErrorLogFlag(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SitePhpErrorLogFlag>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
