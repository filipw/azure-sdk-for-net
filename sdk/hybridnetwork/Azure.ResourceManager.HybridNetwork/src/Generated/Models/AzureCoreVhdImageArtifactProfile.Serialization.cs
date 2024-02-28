// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureCoreVhdImageArtifactProfile : IUtf8JsonSerializable, IJsonModel<AzureCoreVhdImageArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCoreVhdImageArtifactProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureCoreVhdImageArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VhdArtifactProfile != null)
            {
                writer.WritePropertyName("vhdArtifactProfile"u8);
                writer.WriteObjectValue(VhdArtifactProfile);
            }
            if (ArtifactStore != null)
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
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

        AzureCoreVhdImageArtifactProfile IJsonModel<AzureCoreVhdImageArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCoreVhdImageArtifactProfile(document.RootElement, options);
        }

        internal static AzureCoreVhdImageArtifactProfile DeserializeAzureCoreVhdImageArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VhdImageArtifactProfile vhdArtifactProfile = default;
            WritableSubResource artifactStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vhdArtifactProfile = VhdImageArtifactProfile.DeserializeVhdImageArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCoreVhdImageArtifactProfile(artifactStore, serializedAdditionalRawData, vhdArtifactProfile);
        }

        BinaryData IPersistableModel<AzureCoreVhdImageArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{options.Format}' format.");
            }
        }

        AzureCoreVhdImageArtifactProfile IPersistableModel<AzureCoreVhdImageArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureCoreVhdImageArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCoreVhdImageArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
