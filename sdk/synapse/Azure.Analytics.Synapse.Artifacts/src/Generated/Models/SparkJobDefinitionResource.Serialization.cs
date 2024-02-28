// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkJobDefinitionResourceConverter))]
    public partial class SparkJobDefinitionResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static SparkJobDefinitionResource DeserializeSparkJobDefinitionResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkJobDefinition properties = default;
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = SparkJobDefinition.DeserializeSparkJobDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SparkJobDefinitionResource(id, name, type, etag, properties);
        }

        internal partial class SparkJobDefinitionResourceConverter : JsonConverter<SparkJobDefinitionResource>
        {
            public override void Write(Utf8JsonWriter writer, SparkJobDefinitionResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkJobDefinitionResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkJobDefinitionResource(document.RootElement);
            }
        }
    }
}
