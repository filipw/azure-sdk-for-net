// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ExhaustiveKnnParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Metric.HasValue)
            {
                if (Metric != null)
                {
                    writer.WritePropertyName("metric"u8);
                    writer.WriteStringValue(Metric.Value.ToString());
                }
                else
                {
                    writer.WriteNull("metric");
                }
            }
            writer.WriteEndObject();
        }

        internal static ExhaustiveKnnParameters DeserializeExhaustiveKnnParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VectorSearchAlgorithmMetric? metric = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metric = null;
                        continue;
                    }
                    metric = new VectorSearchAlgorithmMetric(property.Value.GetString());
                    continue;
                }
            }
            return new ExhaustiveKnnParameters(metric);
        }
    }
}
