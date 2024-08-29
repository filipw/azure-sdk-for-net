// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearninRegistryComponentContainerResource"/> and their operations.
    /// Each <see cref="MachineLearninRegistryComponentContainerResource"/> in the collection will belong to the same instance of <see cref="MachineLearningRegistryResource"/>.
    /// To get a <see cref="MachineLearninRegistryComponentContainerCollection"/> instance call the GetMachineLearninRegistryComponentContainers method from an instance of <see cref="MachineLearningRegistryResource"/>.
    /// </summary>
    public partial class MachineLearninRegistryComponentContainerCollection : ArmCollection, IEnumerable<MachineLearninRegistryComponentContainerResource>, IAsyncEnumerable<MachineLearninRegistryComponentContainerResource>
    {
        private readonly ClientDiagnostics _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics;
        private readonly RegistryComponentContainersRestOperations _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearninRegistryComponentContainerCollection"/> class for mocking. </summary>
        protected MachineLearninRegistryComponentContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearninRegistryComponentContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearninRegistryComponentContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearninRegistryComponentContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearninRegistryComponentContainerResource.ResourceType, out string machineLearninRegistryComponentContainerRegistryComponentContainersApiVersion);
            _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient = new RegistryComponentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearninRegistryComponentContainerRegistryComponentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearninRegistryComponentContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string componentName, MachineLearningComponentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearninRegistryComponentContainerResource>(new MachineLearninRegistryComponentContainerOperationSource(Client), _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics, Pipeline, _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearninRegistryComponentContainerResource> CreateOrUpdate(WaitUntil waitUntil, string componentName, MachineLearningComponentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearninRegistryComponentContainerResource>(new MachineLearninRegistryComponentContainerOperationSource(Client), _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics, Pipeline, _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<MachineLearninRegistryComponentContainerResource>> GetAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearninRegistryComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<MachineLearninRegistryComponentContainerResource> Get(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearninRegistryComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearninRegistryComponentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearninRegistryComponentContainerResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearninRegistryComponentContainerResource(Client, MachineLearningComponentContainerData.DeserializeMachineLearningComponentContainerData(e)), _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics, Pipeline, "MachineLearninRegistryComponentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearninRegistryComponentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearninRegistryComponentContainerResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearninRegistryComponentContainerResource(Client, MachineLearningComponentContainerData.DeserializeMachineLearningComponentContainerData(e)), _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics, Pipeline, "MachineLearninRegistryComponentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<bool> Exists(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearninRegistryComponentContainerResource>> GetIfExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearninRegistryComponentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearninRegistryComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearninRegistryComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual NullableResponse<MachineLearninRegistryComponentContainerResource> GetIfExists(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _machineLearninRegistryComponentContainerRegistryComponentContainersClientDiagnostics.CreateScope("MachineLearninRegistryComponentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearninRegistryComponentContainerRegistryComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearninRegistryComponentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearninRegistryComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearninRegistryComponentContainerResource> IEnumerable<MachineLearninRegistryComponentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearninRegistryComponentContainerResource> IAsyncEnumerable<MachineLearninRegistryComponentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
