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
    public partial class WorkspaceConnectionAccessKey : IUtf8JsonSerializable, IJsonModel<WorkspaceConnectionAccessKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceConnectionAccessKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkspaceConnectionAccessKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionAccessKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AccessKeyId != null)
            {
                writer.WritePropertyName("accessKeyId"u8);
                writer.WriteStringValue(AccessKeyId);
            }
            if (SecretAccessKey != null)
            {
                writer.WritePropertyName("secretAccessKey"u8);
                writer.WriteStringValue(SecretAccessKey);
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

        WorkspaceConnectionAccessKey IJsonModel<WorkspaceConnectionAccessKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionAccessKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceConnectionAccessKey(document.RootElement, options);
        }

        internal static WorkspaceConnectionAccessKey DeserializeWorkspaceConnectionAccessKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accessKeyId = default;
            string secretAccessKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessKeyId"u8))
                {
                    accessKeyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretAccessKey"u8))
                {
                    secretAccessKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkspaceConnectionAccessKey(accessKeyId, secretAccessKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceConnectionAccessKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionAccessKey)} does not support '{options.Format}' format.");
            }
        }

        WorkspaceConnectionAccessKey IPersistableModel<WorkspaceConnectionAccessKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkspaceConnectionAccessKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionAccessKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkspaceConnectionAccessKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
