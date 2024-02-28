// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemPropertiesHsm : IUtf8JsonSerializable, IJsonModel<AmlFileSystemPropertiesHsm>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemPropertiesHsm>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlFileSystemPropertiesHsm>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemPropertiesHsm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesHsm)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Settings != null)
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings);
            }
            if (options.Format != "W" && !(ArchiveStatus is ChangeTrackingList<AmlFileSystemArchive> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("archiveStatus"u8);
                writer.WriteStartArray();
                foreach (var item in ArchiveStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AmlFileSystemPropertiesHsm IJsonModel<AmlFileSystemPropertiesHsm>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemPropertiesHsm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesHsm)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemPropertiesHsm(document.RootElement, options);
        }

        internal static AmlFileSystemPropertiesHsm DeserializeAmlFileSystemPropertiesHsm(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AmlFileSystemHsmSettings settings = default;
            IReadOnlyList<AmlFileSystemArchive> archiveStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = AmlFileSystemHsmSettings.DeserializeAmlFileSystemHsmSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("archiveStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AmlFileSystemArchive> array = new List<AmlFileSystemArchive>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AmlFileSystemArchive.DeserializeAmlFileSystemArchive(item, options));
                    }
                    archiveStatus = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemPropertiesHsm(settings, archiveStatus ?? new ChangeTrackingList<AmlFileSystemArchive>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemPropertiesHsm>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemPropertiesHsm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemPropertiesHsm)} does not support '{options.Format}' format.");
            }
        }

        AmlFileSystemPropertiesHsm IPersistableModel<AmlFileSystemPropertiesHsm>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemPropertiesHsm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemPropertiesHsm(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemPropertiesHsm)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemPropertiesHsm>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
