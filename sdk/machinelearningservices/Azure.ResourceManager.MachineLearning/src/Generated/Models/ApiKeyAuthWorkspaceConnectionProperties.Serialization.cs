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
    public partial class ApiKeyAuthWorkspaceConnectionProperties : IUtf8JsonSerializable, IJsonModel<ApiKeyAuthWorkspaceConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiKeyAuthWorkspaceConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiKeyAuthWorkspaceConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyAuthWorkspaceConnectionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByWorkspaceArmId))
            {
                writer.WritePropertyName("createdByWorkspaceArmId"u8);
                writer.WriteStringValue(CreatedByWorkspaceArmId);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group.Value.ToString());
            }
            if (Optional.IsDefined(IsSharedToAll))
            {
                writer.WritePropertyName("isSharedToAll"u8);
                writer.WriteBooleanValue(IsSharedToAll.Value);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(PeRequirement))
            {
                writer.WritePropertyName("peRequirement"u8);
                writer.WriteStringValue(PeRequirement.Value.ToString());
            }
            if (Optional.IsDefined(PeStatus))
            {
                writer.WritePropertyName("peStatus"u8);
                writer.WriteStringValue(PeStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SharedUserList))
            {
                writer.WritePropertyName("sharedUserList"u8);
                writer.WriteStartArray();
                foreach (var item in SharedUserList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(UseWorkspaceManagedIdentity))
            {
                writer.WritePropertyName("useWorkspaceManagedIdentity"u8);
                writer.WriteBooleanValue(UseWorkspaceManagedIdentity.Value);
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

        ApiKeyAuthWorkspaceConnectionProperties IJsonModel<ApiKeyAuthWorkspaceConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyAuthWorkspaceConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiKeyAuthWorkspaceConnectionProperties(document.RootElement, options);
        }

        internal static ApiKeyAuthWorkspaceConnectionProperties DeserializeApiKeyAuthWorkspaceConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WorkspaceConnectionApiKey credentials = default;
            MachineLearningConnectionAuthType authType = default;
            MachineLearningConnectionCategory? category = default;
            ResourceIdentifier createdByWorkspaceArmId = default;
            string error = default;
            DateTimeOffset? expiryTime = default;
            ConnectionGroup? group = default;
            bool? isSharedToAll = default;
            IDictionary<string, string> metadata = default;
            ManagedPERequirement? peRequirement = default;
            ManagedPEStatus? peStatus = default;
            IList<string> sharedUserList = default;
            string target = default;
            bool? useWorkspaceManagedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = WorkspaceConnectionApiKey.DeserializeWorkspaceConnectionApiKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdByWorkspaceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByWorkspaceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    group = new ConnectionGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSharedToAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSharedToAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("peRequirement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peRequirement = new ManagedPERequirement(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peStatus = new ManagedPEStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sharedUserList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sharedUserList = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useWorkspaceManagedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useWorkspaceManagedIdentity = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiKeyAuthWorkspaceConnectionProperties(
                authType,
                category,
                createdByWorkspaceArmId,
                error,
                expiryTime,
                group,
                isSharedToAll,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                peRequirement,
                peStatus,
                sharedUserList ?? new ChangeTrackingList<string>(),
                target,
                useWorkspaceManagedIdentity,
                serializedAdditionalRawData,
                credentials);
        }

        BinaryData IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiKeyAuthWorkspaceConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ApiKeyAuthWorkspaceConnectionProperties IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiKeyAuthWorkspaceConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiKeyAuthWorkspaceConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiKeyAuthWorkspaceConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
