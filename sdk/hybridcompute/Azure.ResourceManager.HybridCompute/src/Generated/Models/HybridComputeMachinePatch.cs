// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes a hybrid machine Update. </summary>
    public partial class HybridComputeMachinePatch : HybridComputeResourceUpdate
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputeMachinePatch"/>. </summary>
        public HybridComputeMachinePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachinePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="kind"> Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc. </param>
        /// <param name="locationData"> Metadata pertaining to the geographic location of the resource. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the hybrid machine. </param>
        /// <param name="cloudMetadata"> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </param>
        /// <param name="agentUpgrade"> The info of the machine w.r.t Agent Upgrade. </param>
        /// <param name="parentClusterResourceId"> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this machine is assigned to, if any. </param>
        internal HybridComputeMachinePatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ManagedServiceIdentity identity, ArcKindEnum? kind, HybridComputeLocation locationData, HybridComputeOSProfile osProfile, HybridComputeCloudMetadata cloudMetadata, AgentUpgrade agentUpgrade, ResourceIdentifier parentClusterResourceId, ResourceIdentifier privateLinkScopeResourceId) : base(tags, serializedAdditionalRawData)
        {
            Identity = identity;
            Kind = kind;
            LocationData = locationData;
            OSProfile = osProfile;
            CloudMetadata = cloudMetadata;
            AgentUpgrade = agentUpgrade;
            ParentClusterResourceId = parentClusterResourceId;
            PrivateLinkScopeResourceId = privateLinkScopeResourceId;
        }

        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc. </summary>
        [WirePath("kind")]
        public ArcKindEnum? Kind { get; set; }
        /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
        [WirePath("properties.locationData")]
        public HybridComputeLocation LocationData { get; set; }
        /// <summary> Specifies the operating system settings for the hybrid machine. </summary>
        [WirePath("properties.osProfile")]
        public HybridComputeOSProfile OSProfile { get; set; }
        /// <summary> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </summary>
        internal HybridComputeCloudMetadata CloudMetadata { get; set; }
        /// <summary> Specifies the cloud provider (Azure/AWS/GCP...). </summary>
        [WirePath("properties.cloudMetadata.provider")]
        public string CloudMetadataProvider
        {
            get => CloudMetadata is null ? default : CloudMetadata.Provider;
        }

        /// <summary> The info of the machine w.r.t Agent Upgrade. </summary>
        [WirePath("properties.agentUpgrade")]
        public AgentUpgrade AgentUpgrade { get; set; }
        /// <summary> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </summary>
        [WirePath("properties.parentClusterResourceId")]
        public ResourceIdentifier ParentClusterResourceId { get; set; }
        /// <summary> The resource id of the private link scope this machine is assigned to, if any. </summary>
        [WirePath("properties.privateLinkScopeResourceId")]
        public ResourceIdentifier PrivateLinkScopeResourceId { get; set; }
    }
}
