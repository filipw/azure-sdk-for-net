// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(UserAssignedIdentityConverter))]
    public partial class UserAssignedIdentity : IUtf8JsonSerializable, IJsonModel<UserAssignedIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserAssignedIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UserAssignedIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAssignedIdentity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PrincipalId.HasValue)
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (options.Format != "W" && ClientId.HasValue)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId.Value);
            }
            writer.WriteEndObject();
        }

        UserAssignedIdentity IJsonModel<UserAssignedIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAssignedIdentity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAssignedIdentity(document.RootElement, options);
        }

        internal static UserAssignedIdentity DeserializeUserAssignedIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? principalId = default;
            Guid? clientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
            }
            return new UserAssignedIdentity(principalId, clientId);
        }

        BinaryData IPersistableModel<UserAssignedIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserAssignedIdentity)} does not support '{options.Format}' format.");
            }
        }

        UserAssignedIdentity IPersistableModel<UserAssignedIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserAssignedIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserAssignedIdentity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserAssignedIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class UserAssignedIdentityConverter : JsonConverter<UserAssignedIdentity>
        {
            public override void Write(Utf8JsonWriter writer, UserAssignedIdentity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override UserAssignedIdentity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeUserAssignedIdentity(document.RootElement);
            }
        }
    }
}
