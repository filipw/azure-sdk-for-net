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
    public partial class MarketplaceSubscriptionProperties : IUtf8JsonSerializable, IJsonModel<MarketplaceSubscriptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceSubscriptionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MarketplaceSubscriptionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSubscriptionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MarketplacePlan))
            {
                if (MarketplacePlan != null)
                {
                    writer.WritePropertyName("marketplacePlan"u8);
                    writer.WriteObjectValue(MarketplacePlan, options);
                }
                else
                {
                    writer.WriteNull("marketplacePlan");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSubscriptionStatus))
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus"u8);
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToString());
            }
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        MarketplaceSubscriptionProperties IJsonModel<MarketplaceSubscriptionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSubscriptionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceSubscriptionProperties(document.RootElement, options);
        }

        internal static MarketplaceSubscriptionProperties DeserializeMarketplaceSubscriptionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MarketplacePlan marketplacePlan = default;
            MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus = default;
            string modelId = default;
            MarketplaceSubscriptionProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplacePlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        marketplacePlan = null;
                        continue;
                    }
                    marketplacePlan = MarketplacePlan.DeserializeMarketplacePlan(property.Value, options);
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscriptionStatus = new MarketplaceSubscriptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MarketplaceSubscriptionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MarketplaceSubscriptionProperties(marketplacePlan, marketplaceSubscriptionStatus, modelId, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceSubscriptionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSubscriptionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MarketplaceSubscriptionProperties IPersistableModel<MarketplaceSubscriptionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceSubscriptionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSubscriptionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceSubscriptionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
