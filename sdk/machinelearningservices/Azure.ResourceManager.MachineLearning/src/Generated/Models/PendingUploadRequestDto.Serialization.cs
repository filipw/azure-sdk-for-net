// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PendingUploadRequestDto : IUtf8JsonSerializable, IJsonModel<PendingUploadRequestDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PendingUploadRequestDto>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PendingUploadRequestDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadRequestDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadRequestDto)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PendingUploadId != null)
            {
                if (PendingUploadId != null)
                {
                    writer.WritePropertyName("pendingUploadId"u8);
                    writer.WriteStringValue(PendingUploadId);
                }
                else
                {
                    writer.WriteNull("pendingUploadId");
                }
            }
            if (PendingUploadType.HasValue)
            {
                writer.WritePropertyName("pendingUploadType"u8);
                writer.WriteStringValue(PendingUploadType.Value.ToString());
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

        PendingUploadRequestDto IJsonModel<PendingUploadRequestDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadRequestDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadRequestDto)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePendingUploadRequestDto(document.RootElement, options);
        }

        internal static PendingUploadRequestDto DeserializePendingUploadRequestDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pendingUploadId = default;
            PendingUploadType? pendingUploadType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pendingUploadId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pendingUploadId = null;
                        continue;
                    }
                    pendingUploadId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pendingUploadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingUploadType = new PendingUploadType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PendingUploadRequestDto(pendingUploadId, pendingUploadType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PendingUploadRequestDto>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadRequestDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PendingUploadRequestDto)} does not support '{options.Format}' format.");
            }
        }

        PendingUploadRequestDto IPersistableModel<PendingUploadRequestDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadRequestDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePendingUploadRequestDto(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PendingUploadRequestDto)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PendingUploadRequestDto>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
