// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationSplitProperties : IUtf8JsonSerializable, IJsonModel<ReservationSplitProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationSplitProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationSplitProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSplitProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSplitProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(SplitDestinations is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("splitDestinations"u8);
                writer.WriteStartArray();
                foreach (var item in SplitDestinations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SplitSource != null)
            {
                writer.WritePropertyName("splitSource"u8);
                writer.WriteStringValue(SplitSource);
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

        ReservationSplitProperties IJsonModel<ReservationSplitProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSplitProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSplitProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationSplitProperties(document.RootElement, options);
        }

        internal static ReservationSplitProperties DeserializeReservationSplitProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> splitDestinations = default;
            string splitSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("splitDestinations"u8))
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
                    splitDestinations = array;
                    continue;
                }
                if (property.NameEquals("splitSource"u8))
                {
                    splitSource = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationSplitProperties(splitDestinations ?? new ChangeTrackingList<string>(), splitSource, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationSplitProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSplitProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationSplitProperties)} does not support '{options.Format}' format.");
            }
        }

        ReservationSplitProperties IPersistableModel<ReservationSplitProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSplitProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationSplitProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationSplitProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationSplitProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
