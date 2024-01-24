// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A Class representing a ProvisionedClusterUpgradeProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ProvisionedClusterUpgradeProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetProvisionedClusterUpgradeProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProvisionedClusterResource"/> using the GetProvisionedClusterUpgradeProfile method.
    /// </summary>
    public partial class ProvisionedClusterUpgradeProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProvisionedClusterUpgradeProfileResource"/> instance. </summary>
        /// <param name="connectedClusterResourceUri"> The connectedClusterResourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string connectedClusterResourceUri)
        {
            var resourceId = $"{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/upgradeProfiles/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _provisionedClusterUpgradeProfileprovisionedClusterInstancesClientDiagnostics;
        private readonly ProvisionedClusterInstancesRestOperations _provisionedClusterUpgradeProfileprovisionedClusterInstancesRestClient;
        private readonly ProvisionedClusterUpgradeProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridContainerService/provisionedClusterInstances/upgradeProfiles";

        /// <summary> Initializes a new instance of the <see cref="ProvisionedClusterUpgradeProfileResource"/> class for mocking. </summary>
        protected ProvisionedClusterUpgradeProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProvisionedClusterUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProvisionedClusterUpgradeProfileResource(ArmClient client, ProvisionedClusterUpgradeProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProvisionedClusterUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProvisionedClusterUpgradeProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _provisionedClusterUpgradeProfileprovisionedClusterInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string provisionedClusterUpgradeProfileprovisionedClusterInstancesApiVersion);
            _provisionedClusterUpgradeProfileprovisionedClusterInstancesRestClient = new ProvisionedClusterInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, provisionedClusterUpgradeProfileprovisionedClusterInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProvisionedClusterUpgradeProfileData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the upgrade profile of a provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>provisionedClusterInstances_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProvisionedClusterUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProvisionedClusterUpgradeProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _provisionedClusterUpgradeProfileprovisionedClusterInstancesClientDiagnostics.CreateScope("ProvisionedClusterUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _provisionedClusterUpgradeProfileprovisionedClusterInstancesRestClient.GetUpgradeProfileAsync(Id.Parent.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProvisionedClusterUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the upgrade profile of a provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>provisionedClusterInstances_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProvisionedClusterUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProvisionedClusterUpgradeProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _provisionedClusterUpgradeProfileprovisionedClusterInstancesClientDiagnostics.CreateScope("ProvisionedClusterUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = _provisionedClusterUpgradeProfileprovisionedClusterInstancesRestClient.GetUpgradeProfile(Id.Parent.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProvisionedClusterUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
