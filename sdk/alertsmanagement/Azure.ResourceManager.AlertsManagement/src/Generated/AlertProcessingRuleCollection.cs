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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="AlertProcessingRuleResource"/> and their operations.
    /// Each <see cref="AlertProcessingRuleResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AlertProcessingRuleCollection"/> instance call the GetAlertProcessingRules method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AlertProcessingRuleCollection : ArmCollection, IEnumerable<AlertProcessingRuleResource>, IAsyncEnumerable<AlertProcessingRuleResource>
    {
        private readonly ClientDiagnostics _alertProcessingRuleClientDiagnostics;
        private readonly AlertProcessingRulesRestOperations _alertProcessingRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AlertProcessingRuleCollection"/> class for mocking. </summary>
        protected AlertProcessingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertProcessingRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AlertProcessingRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertProcessingRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", AlertProcessingRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertProcessingRuleResource.ResourceType, out string alertProcessingRuleApiVersion);
            _alertProcessingRuleRestClient = new AlertProcessingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertProcessingRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an alert processing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be created/updated. </param>
        /// <param name="data"> Alert processing rule to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AlertProcessingRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertProcessingRuleName, AlertProcessingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _alertProcessingRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AlertsManagementArmOperation<AlertProcessingRuleResource>(Response.FromValue(new AlertProcessingRuleResource(Client, response), response.GetRawResponse()));
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
        /// Create or update an alert processing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be created/updated. </param>
        /// <param name="data"> Alert processing rule to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AlertProcessingRuleResource> CreateOrUpdate(WaitUntil waitUntil, string alertProcessingRuleName, AlertProcessingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _alertProcessingRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, data, cancellationToken);
                var operation = new AlertsManagementArmOperation<AlertProcessingRuleResource>(Response.FromValue(new AlertProcessingRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get an alert processing rule by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual async Task<Response<AlertProcessingRuleResource>> GetAsync(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertProcessingRuleRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertProcessingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert processing rule by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual Response<AlertProcessingRuleResource> Get(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _alertProcessingRuleRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertProcessingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all alert processing rules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertProcessingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertProcessingRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertProcessingRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertProcessingRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AlertProcessingRuleResource(Client, AlertProcessingRuleData.DeserializeAlertProcessingRuleData(e)), _alertProcessingRuleClientDiagnostics, Pipeline, "AlertProcessingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all alert processing rules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertProcessingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertProcessingRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertProcessingRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertProcessingRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AlertProcessingRuleResource(Client, AlertProcessingRuleData.DeserializeAlertProcessingRuleData(e)), _alertProcessingRuleClientDiagnostics, Pipeline, "AlertProcessingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertProcessingRuleRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertProcessingRuleRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<AlertProcessingRuleResource>> GetIfExistsAsync(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _alertProcessingRuleRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AlertProcessingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertProcessingRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AlertsManagement/actionRules/{alertProcessingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertProcessingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertProcessingRuleName"> The name of the alert processing rule that needs to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertProcessingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertProcessingRuleName"/> is null. </exception>
        public virtual NullableResponse<AlertProcessingRuleResource> GetIfExists(string alertProcessingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertProcessingRuleName, nameof(alertProcessingRuleName));

            using var scope = _alertProcessingRuleClientDiagnostics.CreateScope("AlertProcessingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _alertProcessingRuleRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, alertProcessingRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AlertProcessingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertProcessingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertProcessingRuleResource> IEnumerable<AlertProcessingRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertProcessingRuleResource> IAsyncEnumerable<AlertProcessingRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
