// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderShippingAddress : IUtf8JsonSerializable, IJsonModel<EdgeOrderShippingAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderShippingAddress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderShippingAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderShippingAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderShippingAddress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("streetAddress1"u8);
            writer.WriteStringValue(StreetAddress1);
            if (StreetAddress2 != null)
            {
                writer.WritePropertyName("streetAddress2"u8);
                writer.WriteStringValue(StreetAddress2);
            }
            if (StreetAddress3 != null)
            {
                writer.WritePropertyName("streetAddress3"u8);
                writer.WriteStringValue(StreetAddress3);
            }
            if (City != null)
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (StateOrProvince != null)
            {
                writer.WritePropertyName("stateOrProvince"u8);
                writer.WriteStringValue(StateOrProvince);
            }
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            if (PostalCode != null)
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (ZipExtendedCode != null)
            {
                writer.WritePropertyName("zipExtendedCode"u8);
                writer.WriteStringValue(ZipExtendedCode);
            }
            if (CompanyName != null)
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (AddressType.HasValue)
            {
                writer.WritePropertyName("addressType"u8);
                writer.WriteStringValue(AddressType.Value.ToString());
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

        EdgeOrderShippingAddress IJsonModel<EdgeOrderShippingAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderShippingAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderShippingAddress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderShippingAddress(document.RootElement, options);
        }

        internal static EdgeOrderShippingAddress DeserializeEdgeOrderShippingAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string streetAddress1 = default;
            string streetAddress2 = default;
            string streetAddress3 = default;
            string city = default;
            string stateOrProvince = default;
            string country = default;
            string postalCode = default;
            string zipExtendedCode = default;
            string companyName = default;
            EdgeOrderAddressType? addressType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streetAddress1"u8))
                {
                    streetAddress1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress2"u8))
                {
                    streetAddress2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress3"u8))
                {
                    streetAddress3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateOrProvince"u8))
                {
                    stateOrProvince = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zipExtendedCode"u8))
                {
                    zipExtendedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressType = new EdgeOrderAddressType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderShippingAddress(
                streetAddress1,
                streetAddress2,
                streetAddress3,
                city,
                stateOrProvince,
                country,
                postalCode,
                zipExtendedCode,
                companyName,
                addressType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderShippingAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderShippingAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderShippingAddress)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderShippingAddress IPersistableModel<EdgeOrderShippingAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderShippingAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderShippingAddress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderShippingAddress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderShippingAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
