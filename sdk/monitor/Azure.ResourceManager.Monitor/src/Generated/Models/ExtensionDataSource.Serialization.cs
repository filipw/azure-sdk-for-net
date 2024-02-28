// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ExtensionDataSource : IUtf8JsonSerializable, IJsonModel<ExtensionDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtensionDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtensionDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Streams is ChangeTrackingList<ExtensionDataSourceStream> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("extensionName"u8);
            writer.WriteStringValue(ExtensionName);
            if (ExtensionSettings != null)
            {
                writer.WritePropertyName("extensionSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ExtensionSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ExtensionSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (!(InputDataSources is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("inputDataSources"u8);
                writer.WriteStartArray();
                foreach (var item in InputDataSources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        ExtensionDataSource IJsonModel<ExtensionDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtensionDataSource(document.RootElement, options);
        }

        internal static ExtensionDataSource DeserializeExtensionDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExtensionDataSourceStream> streams = default;
            string extensionName = default;
            BinaryData extensionSettings = default;
            IList<string> inputDataSources = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionDataSourceStream> array = new List<ExtensionDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ExtensionDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("extensionName"u8))
                {
                    extensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionSettings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("inputDataSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inputDataSources = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtensionDataSource(
                streams ?? new ChangeTrackingList<ExtensionDataSourceStream>(),
                extensionName,
                extensionSettings,
                inputDataSources ?? new ChangeTrackingList<string>(),
                name,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtensionDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtensionDataSource)} does not support '{options.Format}' format.");
            }
        }

        ExtensionDataSource IPersistableModel<ExtensionDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtensionDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtensionDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtensionDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
