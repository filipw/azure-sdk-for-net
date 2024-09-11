// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetLinuxPatchSettings : IUtf8JsonSerializable, IJsonModel<ComputeFleetLinuxPatchSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetLinuxPatchSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetLinuxPatchSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetLinuxPatchSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            if (Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Optional.IsDefined(AutomaticByPlatformSettings))
            {
                writer.WritePropertyName("automaticByPlatformSettings"u8);
                writer.WriteObjectValue(AutomaticByPlatformSettings, options);
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

        ComputeFleetLinuxPatchSettings IJsonModel<ComputeFleetLinuxPatchSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetLinuxPatchSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetLinuxPatchSettings(document.RootElement, options);
        }

        internal static ComputeFleetLinuxPatchSettings DeserializeComputeFleetLinuxPatchSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeFleetLinuxVmGuestPatchMode? patchMode = default;
            ComputeFleetLinuxPatchAssessmentMode? assessmentMode = default;
            ComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings automaticByPlatformSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchMode = new ComputeFleetLinuxVmGuestPatchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentMode = new ComputeFleetLinuxPatchAssessmentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automaticByPlatformSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticByPlatformSettings = ComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings.DeserializeComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetLinuxPatchSettings(patchMode, assessmentMode, automaticByPlatformSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetLinuxPatchSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetLinuxPatchSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetLinuxPatchSettings IPersistableModel<ComputeFleetLinuxPatchSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeFleetLinuxPatchSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetLinuxPatchSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetLinuxPatchSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
