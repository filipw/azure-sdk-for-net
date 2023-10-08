// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoClusterVirtualNetworkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("enginePublicIpId"u8);
            writer.WriteStringValue(EnginePublicIPId);
            writer.WritePropertyName("dataManagementPublicIpId"u8);
            writer.WriteStringValue(DataManagementPublicIPId);
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static KustoClusterVirtualNetworkConfiguration DeserializeKustoClusterVirtualNetworkConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subnetId = default;
            string enginePublicIPId = default;
            string dataManagementPublicIPId = default;
            Optional<VnetState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enginePublicIpId"u8))
                {
                    enginePublicIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataManagementPublicIpId"u8))
                {
                    dataManagementPublicIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new VnetState(property.Value.GetString());
                    continue;
                }
            }
            return new KustoClusterVirtualNetworkConfiguration(subnetId, enginePublicIPId, dataManagementPublicIPId, Optional.ToNullable(state));
        }
    }
}
