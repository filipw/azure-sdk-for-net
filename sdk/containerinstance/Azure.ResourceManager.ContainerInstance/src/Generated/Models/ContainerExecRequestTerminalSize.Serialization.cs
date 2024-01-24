// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerExecRequestTerminalSize : IUtf8JsonSerializable, IJsonModel<ContainerExecRequestTerminalSize>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerExecRequestTerminalSize>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerExecRequestTerminalSize>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerExecRequestTerminalSize>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerExecRequestTerminalSize)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Rows))
            {
                writer.WritePropertyName("rows"u8);
                writer.WriteNumberValue(Rows.Value);
            }
            if (Optional.IsDefined(Cols))
            {
                writer.WritePropertyName("cols"u8);
                writer.WriteNumberValue(Cols.Value);
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

        ContainerExecRequestTerminalSize IJsonModel<ContainerExecRequestTerminalSize>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerExecRequestTerminalSize>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerExecRequestTerminalSize)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerExecRequestTerminalSize(document.RootElement, options);
        }

        internal static ContainerExecRequestTerminalSize DeserializeContainerExecRequestTerminalSize(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> rows = default;
            Optional<int> cols = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cols = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerExecRequestTerminalSize(Optional.ToNullable(rows), Optional.ToNullable(cols), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerExecRequestTerminalSize>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerExecRequestTerminalSize>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerExecRequestTerminalSize)} does not support '{options.Format}' format.");
            }
        }

        ContainerExecRequestTerminalSize IPersistableModel<ContainerExecRequestTerminalSize>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerExecRequestTerminalSize>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerExecRequestTerminalSize(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerExecRequestTerminalSize)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerExecRequestTerminalSize>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
