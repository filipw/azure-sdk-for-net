// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class PiiTaskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Domain.HasValue)
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain.Value.ToString());
            }
            if (!(PiiCategories is ChangeTrackingList<PiiEntityCategory> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("piiCategories"u8);
                writer.WriteStartArray();
                foreach (var item in PiiCategories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (StringIndexType.HasValue)
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (ModelVersion != null)
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (LoggingOptOut.HasValue)
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            writer.WriteEndObject();
        }

        internal static PiiTaskParameters DeserializePiiTaskParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PiiDomain? domain = default;
            IList<PiiEntityCategory> piiCategories = default;
            StringIndexType? stringIndexType = default;
            string modelVersion = default;
            bool? loggingOptOut = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domain = new PiiDomain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("piiCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PiiEntityCategory> array = new List<PiiEntityCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PiiEntityCategory(item.GetString()));
                    }
                    piiCategories = array;
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
            }
            return new PiiTaskParameters(loggingOptOut, modelVersion, domain, piiCategories ?? new ChangeTrackingList<PiiEntityCategory>(), stringIndexType);
        }
    }
}
