// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing an AppServicePlanHybridConnectionNamespaceRelay along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppServicePlanHybridConnectionNamespaceRelayResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServicePlanResource"/> using the GetAppServicePlanHybridConnectionNamespaceRelay method.
    /// </summary>
    public partial class AppServicePlanHybridConnectionNamespaceRelayResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="namespaceName"> The namespaceName. </param>
        /// <param name="relayName"> The relayName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string namespaceName, string relayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient;
        private readonly HybridConnectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/hybridConnectionNamespaces/relays";

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/> class for mocking. </summary>
        protected AppServicePlanHybridConnectionNamespaceRelayResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppServicePlanHybridConnectionNamespaceRelayResource(ArmClient client, HybridConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppServicePlanHybridConnectionNamespaceRelayResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appServicePlanHybridConnectionNamespaceRelayAppServicePlansApiVersion);
            _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServicePlanHybridConnectionNamespaceRelayAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridConnectionData Data
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
        /// Description for Retrieve a Hybrid Connection in use in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppServicePlanHybridConnectionNamespaceRelayResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.GetHybridConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicePlanHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Retrieve a Hybrid Connection in use in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppServicePlanHybridConnectionNamespaceRelayResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.Get");
            scope.Start();
            try
            {
                var response = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.GetHybridConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicePlanHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Hybrid Connection in use in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_DeleteHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.Delete");
            scope.Start();
            try
            {
                var response = await _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.DeleteHybridConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateDeleteHybridConnectionRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Hybrid Connection in use in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_DeleteHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.Delete");
            scope.Start();
            try
            {
                var response = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.DeleteHybridConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateDeleteHybridConnectionRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the send key name and value of a Hybrid Connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_ListHybridConnectionKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridConnectionKey>> GetHybridConnectionKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.GetHybridConnectionKeys");
            scope.Start();
            try
            {
                var response = await _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.ListHybridConnectionKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the send key name and value of a Hybrid Connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_ListHybridConnectionKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridConnectionKey> GetHybridConnectionKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanHybridConnectionNamespaceRelayResource.GetHybridConnectionKeys");
            scope.Start();
            try
            {
                var response = _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.ListHybridConnectionKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all apps that use a Hybrid Connection in an App Service Plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_ListWebAppsByHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<string> GetWebAppsByHybridConnectionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateListWebAppsByHybridConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateListWebAppsByHybridConnectionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => e.GetString(), _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics, Pipeline, "AppServicePlanHybridConnectionNamespaceRelayResource.GetWebAppsByHybridConnection", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all apps that use a Hybrid Connection in an App Service Plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_ListWebAppsByHybridConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServicePlanHybridConnectionNamespaceRelayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<string> GetWebAppsByHybridConnection(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateListWebAppsByHybridConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServicePlanHybridConnectionNamespaceRelayAppServicePlansRestClient.CreateListWebAppsByHybridConnectionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => e.GetString(), _appServicePlanHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics, Pipeline, "AppServicePlanHybridConnectionNamespaceRelayResource.GetWebAppsByHybridConnection", "value", "nextLink", cancellationToken);
        }
    }
}
