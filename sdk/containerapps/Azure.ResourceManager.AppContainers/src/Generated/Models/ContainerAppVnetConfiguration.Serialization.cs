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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppVnetConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppVnetConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppVnetConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppVnetConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsInternal))
            {
                writer.WritePropertyName("internal"u8);
                writer.WriteBooleanValue(IsInternal.Value);
            }
            if (Optional.IsDefined(InfrastructureSubnetId))
            {
                writer.WritePropertyName("infrastructureSubnetId"u8);
                writer.WriteStringValue(InfrastructureSubnetId);
            }
            if (Optional.IsDefined(DockerBridgeCidr))
            {
                writer.WritePropertyName("dockerBridgeCidr"u8);
                writer.WriteStringValue(DockerBridgeCidr);
            }
            if (Optional.IsDefined(PlatformReservedCidr))
            {
                writer.WritePropertyName("platformReservedCidr"u8);
                writer.WriteStringValue(PlatformReservedCidr);
            }
            if (Optional.IsDefined(PlatformReservedDnsIP))
            {
                writer.WritePropertyName("platformReservedDnsIP"u8);
                writer.WriteStringValue(PlatformReservedDnsIP);
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
        }

        ContainerAppVnetConfiguration IJsonModel<ContainerAppVnetConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppVnetConfiguration(document.RootElement, options);
        }

        internal static ContainerAppVnetConfiguration DeserializeContainerAppVnetConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? @internal = default;
            ResourceIdentifier infrastructureSubnetId = default;
            string dockerBridgeCidr = default;
            string platformReservedCidr = default;
            string platformReservedDnsIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @internal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("infrastructureSubnetId"u8))
                {
                    DeserializeInfrastructureSubnetIdValue(property, ref infrastructureSubnetId);
                    continue;
                }
                if (property.NameEquals("dockerBridgeCidr"u8))
                {
                    dockerBridgeCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platformReservedCidr"u8))
                {
                    platformReservedCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platformReservedDnsIP"u8))
                {
                    platformReservedDnsIP = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppVnetConfiguration(
                @internal,
                infrastructureSubnetId,
                dockerBridgeCidr,
                platformReservedCidr,
                platformReservedDnsIP,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsInternal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  internal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsInternal))
                {
                    builder.Append("  internal: ");
                    var boolValue = IsInternal.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InfrastructureSubnetId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  infrastructureSubnetId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InfrastructureSubnetId))
                {
                    builder.Append("  infrastructureSubnetId: ");
                    builder.AppendLine($"'{InfrastructureSubnetId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DockerBridgeCidr), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dockerBridgeCidr: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DockerBridgeCidr))
                {
                    builder.Append("  dockerBridgeCidr: ");
                    if (DockerBridgeCidr.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DockerBridgeCidr}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DockerBridgeCidr}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformReservedCidr), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  platformReservedCidr: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlatformReservedCidr))
                {
                    builder.Append("  platformReservedCidr: ");
                    if (PlatformReservedCidr.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PlatformReservedCidr}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PlatformReservedCidr}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformReservedDnsIP), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  platformReservedDnsIP: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlatformReservedDnsIP))
                {
                    builder.Append("  platformReservedDnsIP: ");
                    if (PlatformReservedDnsIP.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PlatformReservedDnsIP}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PlatformReservedDnsIP}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppVnetConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppVnetConfiguration IPersistableModel<ContainerAppVnetConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppVnetConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppVnetConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
