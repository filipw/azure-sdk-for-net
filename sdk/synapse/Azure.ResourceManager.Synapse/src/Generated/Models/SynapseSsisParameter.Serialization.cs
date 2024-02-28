// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisParameter : IUtf8JsonSerializable, IJsonModel<SynapseSsisParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSsisParameter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSsisParameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisParameter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (DataType != null)
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (IsRequired.HasValue)
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (IsSensitive.HasValue)
            {
                writer.WritePropertyName("sensitive"u8);
                writer.WriteBooleanValue(IsSensitive.Value);
            }
            if (DesignDefaultValue != null)
            {
                writer.WritePropertyName("designDefaultValue"u8);
                writer.WriteStringValue(DesignDefaultValue);
            }
            if (DefaultValue != null)
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (SensitiveDefaultValue != null)
            {
                writer.WritePropertyName("sensitiveDefaultValue"u8);
                writer.WriteStringValue(SensitiveDefaultValue);
            }
            if (ValueType != null)
            {
                writer.WritePropertyName("valueType"u8);
                writer.WriteStringValue(ValueType);
            }
            if (ValueSet.HasValue)
            {
                writer.WritePropertyName("valueSet"u8);
                writer.WriteBooleanValue(ValueSet.Value);
            }
            if (Variable != null)
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
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

        SynapseSsisParameter IJsonModel<SynapseSsisParameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisParameter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisParameter(document.RootElement, options);
        }

        internal static SynapseSsisParameter DeserializeSynapseSsisParameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? id = default;
            string name = default;
            string description = default;
            string dataType = default;
            bool? required = default;
            bool? sensitive = default;
            string designDefaultValue = default;
            string defaultValue = default;
            string sensitiveDefaultValue = default;
            string valueType = default;
            bool? valueSet = default;
            string variable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("designDefaultValue"u8))
                {
                    designDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sensitiveDefaultValue"u8))
                {
                    sensitiveDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    valueType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseSsisParameter(
                id,
                name,
                description,
                dataType,
                required,
                sensitive,
                designDefaultValue,
                defaultValue,
                sensitiveDefaultValue,
                valueType,
                valueSet,
                variable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSsisParameter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisParameter)} does not support '{options.Format}' format.");
            }
        }

        SynapseSsisParameter IPersistableModel<SynapseSsisParameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSsisParameter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisParameter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSsisParameter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
