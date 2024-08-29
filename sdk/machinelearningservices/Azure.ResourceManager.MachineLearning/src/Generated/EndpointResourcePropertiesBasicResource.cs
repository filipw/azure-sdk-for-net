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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing an EndpointResourcePropertiesBasicResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="EndpointResourcePropertiesBasicResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetEndpointResourcePropertiesBasicResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningWorkspaceResource"/> using the GetEndpointResourcePropertiesBasicResource method.
    /// </summary>
    public partial class EndpointResourcePropertiesBasicResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EndpointResourcePropertiesBasicResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="endpointName"> The endpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string endpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics;
        private readonly EndpointRestOperations _endpointResourcePropertiesBasicResourceEndpointRestClient;
        private readonly EndpointResourcePropertiesBasicResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/endpoints";

        /// <summary> Initializes a new instance of the <see cref="EndpointResourcePropertiesBasicResource"/> class for mocking. </summary>
        protected EndpointResourcePropertiesBasicResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointResourcePropertiesBasicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EndpointResourcePropertiesBasicResource(ArmClient client, EndpointResourcePropertiesBasicResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointResourcePropertiesBasicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EndpointResourcePropertiesBasicResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string endpointResourcePropertiesBasicResourceEndpointApiVersion);
            _endpointResourcePropertiesBasicResourceEndpointRestClient = new EndpointRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, endpointResourcePropertiesBasicResourceEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EndpointResourcePropertiesBasicResourceData Data
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

        /// <summary> Gets a collection of WorkspaceEndpointDeploymentResources in the EndpointResourcePropertiesBasicResource. </summary>
        /// <returns> An object representing collection of WorkspaceEndpointDeploymentResources and their operations over a WorkspaceEndpointDeploymentResource. </returns>
        public virtual WorkspaceEndpointDeploymentCollection GetWorkspaceEndpointDeployments()
        {
            return GetCachedClient(client => new WorkspaceEndpointDeploymentCollection(client, Id));
        }

        /// <summary>
        /// Get deployments under endpoint resource by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointDeployment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspaceEndpointDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> Name of the deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkspaceEndpointDeploymentResource>> GetWorkspaceEndpointDeploymentAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            return await GetWorkspaceEndpointDeployments().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get deployments under endpoint resource by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointDeployment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspaceEndpointDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> Name of the deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkspaceEndpointDeploymentResource> GetWorkspaceEndpointDeployment(string deploymentName, CancellationToken cancellationToken = default)
        {
            return GetWorkspaceEndpointDeployments().Get(deploymentName, cancellationToken);
        }

        /// <summary> Gets a collection of WorkspaceEndpointRaiPolicyResources in the EndpointResourcePropertiesBasicResource. </summary>
        /// <returns> An object representing collection of WorkspaceEndpointRaiPolicyResources and their operations over a WorkspaceEndpointRaiPolicyResource. </returns>
        public virtual WorkspaceEndpointRaiPolicyCollection GetWorkspaceEndpointRaiPolicies()
        {
            return GetCachedClient(client => new WorkspaceEndpointRaiPolicyCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Content Filters associated with the Azure OpenAI account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/raiPolicies/{raiPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspaceEndpointRaiPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiPolicyName"> Name of the Rai Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="raiPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="raiPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkspaceEndpointRaiPolicyResource>> GetWorkspaceEndpointRaiPolicyAsync(string raiPolicyName, CancellationToken cancellationToken = default)
        {
            return await GetWorkspaceEndpointRaiPolicies().GetAsync(raiPolicyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Content Filters associated with the Azure OpenAI account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/raiPolicies/{raiPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspaceEndpointRaiPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiPolicyName"> Name of the Rai Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="raiPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="raiPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkspaceEndpointRaiPolicyResource> GetWorkspaceEndpointRaiPolicy(string raiPolicyName, CancellationToken cancellationToken = default)
        {
            return GetWorkspaceEndpointRaiPolicies().Get(raiPolicyName, cancellationToken);
        }

        /// <summary>
        /// Gets endpoint resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointResourcePropertiesBasicResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.Get");
            scope.Start();
            try
            {
                var response = await _endpointResourcePropertiesBasicResourceEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResourcePropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets endpoint resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointResourcePropertiesBasicResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.Get");
            scope.Start();
            try
            {
                var response = _endpointResourcePropertiesBasicResourceEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResourcePropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update endpoint resource with the specified parameters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Endpoint resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EndpointResourcePropertiesBasicResource>> UpdateAsync(WaitUntil waitUntil, EndpointResourcePropertiesBasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.Update");
            scope.Start();
            try
            {
                var response = await _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<EndpointResourcePropertiesBasicResource>(new EndpointResourcePropertiesBasicResourceOperationSource(Client), _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics, Pipeline, _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update endpoint resource with the specified parameters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Endpoint resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EndpointResourcePropertiesBasicResource> Update(WaitUntil waitUntil, EndpointResourcePropertiesBasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.Update");
            scope.Start();
            try
            {
                var response = _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<EndpointResourcePropertiesBasicResource>(new EndpointResourcePropertiesBasicResourceOperationSource(Client), _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics, Pipeline, _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List keys for the endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _endpointResourcePropertiesBasicResourceEndpointRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List keys for the endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.GetKeys");
            scope.Start();
            try
            {
                var response = _endpointResourcePropertiesBasicResourceEndpointRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get available models under the endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_GetModels</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EndpointModelProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EndpointModelProperties> GetModelsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateGetModelsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateGetModelsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => EndpointModelProperties.DeserializeEndpointModelProperties(e), _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics, Pipeline, "EndpointResourcePropertiesBasicResource.GetModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get available models under the endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_GetModels</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EndpointModelProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EndpointModelProperties> GetModels(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateGetModelsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointResourcePropertiesBasicResourceEndpointRestClient.CreateGetModelsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => EndpointModelProperties.DeserializeEndpointModelProperties(e), _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics, Pipeline, "EndpointResourcePropertiesBasicResource.GetModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Regenerate account keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/regenerateKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_RegenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The <see cref="RegenerateServiceAccountKeyContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AccountApiKeys>> RegenerateKeysAsync(RegenerateServiceAccountKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _endpointResourcePropertiesBasicResourceEndpointRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerate account keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/endpoints/{endpointName}/regenerateKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoint_RegenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResourcePropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The <see cref="RegenerateServiceAccountKeyContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AccountApiKeys> RegenerateKeys(RegenerateServiceAccountKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _endpointResourcePropertiesBasicResourceEndpointClientDiagnostics.CreateScope("EndpointResourcePropertiesBasicResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _endpointResourcePropertiesBasicResourceEndpointRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
