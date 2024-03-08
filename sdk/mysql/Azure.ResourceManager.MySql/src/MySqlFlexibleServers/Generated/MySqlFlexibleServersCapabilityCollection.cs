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
using Azure.ResourceManager.MySql;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServersCapabilityResource"/> and their operations.
    /// Each <see cref="MySqlFlexibleServersCapabilityResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="MySqlFlexibleServersCapabilityCollection"/> instance call the GetMySqlFlexibleServersCapabilities method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class MySqlFlexibleServersCapabilityCollection : ArmCollection, IEnumerable<MySqlFlexibleServersCapabilityResource>, IAsyncEnumerable<MySqlFlexibleServersCapabilityResource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics;
        private readonly LocationBasedCapabilitySetRestOperations _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServersCapabilityCollection"/> class for mocking. </summary>
        protected MySqlFlexibleServersCapabilityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServersCapabilityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the location. </param>
        internal MySqlFlexibleServersCapabilityCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServersCapabilityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServersCapabilityResource.ResourceType, out string mySqlFlexibleServersCapabilityLocationBasedCapabilitySetApiVersion);
            _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient = new LocationBasedCapabilitySetRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServersCapabilityLocationBasedCapabilitySetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual async Task<Response<MySqlFlexibleServersCapabilityResource>> GetAsync(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServersCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual Response<MySqlFlexibleServersCapabilityResource> Get(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServersCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServersCapabilityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServersCapabilityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServersCapabilityResource(Client, MySqlFlexibleServersCapabilityData.DeserializeMySqlFlexibleServersCapabilityData(e)), _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics, Pipeline, "MySqlFlexibleServersCapabilityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServersCapabilityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServersCapabilityResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServersCapabilityResource(Client, MySqlFlexibleServersCapabilityData.DeserializeMySqlFlexibleServersCapabilityData(e)), _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics, Pipeline, "MySqlFlexibleServersCapabilityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlFlexibleServersCapabilityResource>> GetIfExistsAsync(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServersCapabilityResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServersCapabilityResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilitySets/{capabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilitySet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServersCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilitySetName"> Name of capability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitySetName"/> is null. </exception>
        public virtual NullableResponse<MySqlFlexibleServersCapabilityResource> GetIfExists(string capabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilitySetName, nameof(capabilitySetName));

            using var scope = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetClientDiagnostics.CreateScope("MySqlFlexibleServersCapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServersCapabilityLocationBasedCapabilitySetRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), capabilitySetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServersCapabilityResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServersCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServersCapabilityResource> IEnumerable<MySqlFlexibleServersCapabilityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServersCapabilityResource> IAsyncEnumerable<MySqlFlexibleServersCapabilityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
