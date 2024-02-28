// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MediaUri : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Uri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri);
            }
            writer.WriteEndObject();
        }

        internal static MediaUri DeserializeMediaUri(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    uri = property.Value.GetString();
                    continue;
                }
            }
            return new MediaUri(uri);
        }
    }
}
