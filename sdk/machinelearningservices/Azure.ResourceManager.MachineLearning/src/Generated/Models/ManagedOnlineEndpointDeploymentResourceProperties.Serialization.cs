// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedOnlineEndpointDeploymentResourceProperties : IUtf8JsonSerializable, IJsonModel<ManagedOnlineEndpointDeploymentResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedOnlineEndpointDeploymentResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedOnlineEndpointDeploymentResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedOnlineEndpointDeploymentResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointComputeType))
            {
                writer.WritePropertyName("endpointComputeType"u8);
                writer.WriteStringValue(EndpointComputeType.Value.ToString());
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason"u8);
                writer.WriteStringValue(FailureReason);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(EndpointDeploymentResourcePropertiesType);
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

        ManagedOnlineEndpointDeploymentResourceProperties IJsonModel<ManagedOnlineEndpointDeploymentResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedOnlineEndpointDeploymentResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedOnlineEndpointDeploymentResourceProperties(document.RootElement, options);
        }

        internal static ManagedOnlineEndpointDeploymentResourceProperties DeserializeManagedOnlineEndpointDeploymentResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningEndpointComputeType? endpointComputeType = default;
            string model = default;
            string failureReason = default;
            DefaultResourceProvisioningState? provisioningState = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointComputeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointComputeType = new MachineLearningEndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failureReason"u8))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DefaultResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedOnlineEndpointDeploymentResourceProperties(
                failureReason,
                provisioningState,
                type,
                serializedAdditionalRawData,
                endpointComputeType,
                model);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointComputeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointComputeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointComputeType))
                {
                    builder.Append("  endpointComputeType: ");
                    builder.AppendLine($"'{EndpointComputeType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Model), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  model: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Model))
                {
                    builder.Append("  model: ");
                    if (Model.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Model}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Model}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FailureReason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  failureReason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FailureReason))
                {
                    builder.Append("  failureReason: ");
                    if (FailureReason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FailureReason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FailureReason}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointDeploymentResourcePropertiesType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointDeploymentResourcePropertiesType))
                {
                    builder.Append("  type: ");
                    if (EndpointDeploymentResourcePropertiesType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndpointDeploymentResourcePropertiesType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndpointDeploymentResourcePropertiesType}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedOnlineEndpointDeploymentResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedOnlineEndpointDeploymentResourceProperties IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedOnlineEndpointDeploymentResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedOnlineEndpointDeploymentResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedOnlineEndpointDeploymentResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
