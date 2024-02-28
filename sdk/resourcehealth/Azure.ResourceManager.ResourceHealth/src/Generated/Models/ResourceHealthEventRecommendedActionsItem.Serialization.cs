// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventRecommendedActionsItem : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventRecommendedActionsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventRecommendedActionsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthEventRecommendedActionsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActionsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActionsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (GroupId.HasValue)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteNumberValue(GroupId.Value);
            }
            if (ActionText != null)
            {
                writer.WritePropertyName("actionText"u8);
                writer.WriteStringValue(ActionText);
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

        ResourceHealthEventRecommendedActionsItem IJsonModel<ResourceHealthEventRecommendedActionsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActionsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActionsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventRecommendedActionsItem(document.RootElement, options);
        }

        internal static ResourceHealthEventRecommendedActionsItem DeserializeResourceHealthEventRecommendedActionsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? groupId = default;
            string actionText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actionText"u8))
                {
                    actionText = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthEventRecommendedActionsItem(groupId, actionText, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthEventRecommendedActionsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActionsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActionsItem)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthEventRecommendedActionsItem IPersistableModel<ResourceHealthEventRecommendedActionsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActionsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventRecommendedActionsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActionsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventRecommendedActionsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
