// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningManagedIdentityAuthTypeWorkspaceConnection : IUtf8JsonSerializable, IJsonModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningManagedIdentityAuthTypeWorkspaceConnection)} does not support writing '{format}' format.");
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

        MachineLearningManagedIdentityAuthTypeWorkspaceConnection IJsonModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningManagedIdentityAuthTypeWorkspaceConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningManagedIdentityAuthTypeWorkspaceConnection(document.RootElement, options);
        }

        internal static MachineLearningManagedIdentityAuthTypeWorkspaceConnection DeserializeMachineLearningManagedIdentityAuthTypeWorkspaceConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningWorkspaceConnectionManagedIdentity credentials = default;
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
                    credentials = MachineLearningWorkspaceConnectionManagedIdentity.DeserializeMachineLearningWorkspaceConnectionManagedIdentity(property.Value, options);
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
            return new MachineLearningManagedIdentityAuthTypeWorkspaceConnection(
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

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credentials))
                {
                    builder.Append("  credentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credentials, options, 2, false, "  credentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  authType: ");
                builder.AppendLine($"'{AuthType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Category), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  category: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Category))
                {
                    builder.Append("  category: ");
                    builder.AppendLine($"'{Category.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedByWorkspaceArmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdByWorkspaceArmId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedByWorkspaceArmId))
                {
                    builder.Append("  createdByWorkspaceArmId: ");
                    builder.AppendLine($"'{CreatedByWorkspaceArmId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Error), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  error: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Error))
                {
                    builder.Append("  error: ");
                    if (Error.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Error}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Error}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpiryOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiryTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpiryOn))
                {
                    builder.Append("  expiryTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpiryOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Group), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  group: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Group))
                {
                    builder.Append("  group: ");
                    builder.AppendLine($"'{Group.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSharedToAll), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSharedToAll: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSharedToAll))
                {
                    builder.Append("  isSharedToAll: ");
                    var boolValue = IsSharedToAll.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metadata), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metadata: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Metadata))
                {
                    if (Metadata.Any())
                    {
                        builder.Append("  metadata: ");
                        builder.AppendLine("{");
                        foreach (var item in Metadata)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeRequirement), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  peRequirement: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PeRequirement))
                {
                    builder.Append("  peRequirement: ");
                    builder.AppendLine($"'{PeRequirement.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  peStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PeStatus))
                {
                    builder.Append("  peStatus: ");
                    builder.AppendLine($"'{PeStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SharedUserList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sharedUserList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SharedUserList))
                {
                    if (SharedUserList.Any())
                    {
                        builder.Append("  sharedUserList: ");
                        builder.AppendLine("[");
                        foreach (var item in SharedUserList)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    if (Target.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Target}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Target}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UseWorkspaceManagedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  useWorkspaceManagedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UseWorkspaceManagedIdentity))
                {
                    builder.Append("  useWorkspaceManagedIdentity: ");
                    var boolValue = UseWorkspaceManagedIdentity.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningManagedIdentityAuthTypeWorkspaceConnection)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningManagedIdentityAuthTypeWorkspaceConnection IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningManagedIdentityAuthTypeWorkspaceConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningManagedIdentityAuthTypeWorkspaceConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningManagedIdentityAuthTypeWorkspaceConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
