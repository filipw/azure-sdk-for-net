// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementApiReleaseDeletedEventDataConverter))]
    public partial class ApiManagementApiReleaseDeletedEventData
    {
        internal static ApiManagementApiReleaseDeletedEventData DeserializeApiManagementApiReleaseDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementApiReleaseDeletedEventData(resourceUri);
        }

        internal partial class ApiManagementApiReleaseDeletedEventDataConverter : JsonConverter<ApiManagementApiReleaseDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementApiReleaseDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementApiReleaseDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementApiReleaseDeletedEventData(document.RootElement);
            }
        }
    }
}
