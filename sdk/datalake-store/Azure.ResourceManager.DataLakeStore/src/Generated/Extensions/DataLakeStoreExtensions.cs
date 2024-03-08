// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Mocking;
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataLakeStore. </summary>
    public static partial class DataLakeStoreExtensions
    {
        private static MockableDataLakeStoreArmClient GetMockableDataLakeStoreArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDataLakeStoreArmClient(client0));
        }

        private static MockableDataLakeStoreResourceGroupResource GetMockableDataLakeStoreResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataLakeStoreResourceGroupResource(client, resource.Id));
        }

        private static MockableDataLakeStoreSubscriptionResource GetMockableDataLakeStoreSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataLakeStoreSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreArmClient.GetDataLakeStoreAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DataLakeStoreAccountResource"/> object. </returns>
        public static DataLakeStoreAccountResource GetDataLakeStoreAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDataLakeStoreArmClient(client).GetDataLakeStoreAccountResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreArmClient.GetDataLakeStoreFirewallRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DataLakeStoreFirewallRuleResource"/> object. </returns>
        public static DataLakeStoreFirewallRuleResource GetDataLakeStoreFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDataLakeStoreArmClient(client).GetDataLakeStoreFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreVirtualNetworkRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreVirtualNetworkRuleResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreVirtualNetworkRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreArmClient.GetDataLakeStoreVirtualNetworkRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DataLakeStoreVirtualNetworkRuleResource"/> object. </returns>
        public static DataLakeStoreVirtualNetworkRuleResource GetDataLakeStoreVirtualNetworkRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDataLakeStoreArmClient(client).GetDataLakeStoreVirtualNetworkRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreTrustedIdProviderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreTrustedIdProviderResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreTrustedIdProviderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreArmClient.GetDataLakeStoreTrustedIdProviderResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DataLakeStoreTrustedIdProviderResource"/> object. </returns>
        public static DataLakeStoreTrustedIdProviderResource GetDataLakeStoreTrustedIdProviderResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDataLakeStoreArmClient(client).GetDataLakeStoreTrustedIdProviderResource(id);
        }

        /// <summary>
        /// Gets a collection of DataLakeStoreAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreResourceGroupResource.GetDataLakeStoreAccounts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DataLakeStoreAccountResources and their operations over a DataLakeStoreAccountResource. </returns>
        public static DataLakeStoreAccountCollection GetDataLakeStoreAccounts(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataLakeStoreResourceGroupResource(resourceGroupResource).GetDataLakeStoreAccounts();
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreResourceGroupResource.GetDataLakeStoreAccountAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataLakeStoreAccountResource>> GetDataLakeStoreAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDataLakeStoreResourceGroupResource(resourceGroupResource).GetDataLakeStoreAccountAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreResourceGroupResource.GetDataLakeStoreAccount(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DataLakeStoreAccountResource> GetDataLakeStoreAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataLakeStoreResourceGroupResource(resourceGroupResource).GetDataLakeStoreAccount(accountName, cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The response includes a link to the next page of results, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetAccounts(SubscriptionResourceGetAccountsOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataLakeStoreAccountBasicData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataLakeStoreAccountBasicData> GetAccountsAsync(this SubscriptionResource subscriptionResource, SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetAccountsAsync(options, cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The response includes a link to the next page of results, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetAccounts(SubscriptionResourceGetAccountsOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DataLakeStoreAccountBasicData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataLakeStoreAccountBasicData> GetAccounts(this SubscriptionResource subscriptionResource, SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetAccounts(options, cancellationToken);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.CheckDataLakeStoreAccountNameAvailability(AzureLocation,DataLakeStoreAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Store account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DataLakeStoreAccountNameAvailabilityResult>> CheckDataLakeStoreAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, DataLakeStoreAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).CheckDataLakeStoreAccountNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.CheckDataLakeStoreAccountNameAvailability(AzureLocation,DataLakeStoreAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Store account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DataLakeStoreAccountNameAvailabilityResult> CheckDataLakeStoreAccountNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, DataLakeStoreAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).CheckDataLakeStoreAccountNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Store specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetCapabilityByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static async Task<Response<DataLakeStoreCapabilityInformation>> GetCapabilityByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetCapabilityByLocationAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Store specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetCapabilityByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static Response<DataLakeStoreCapabilityInformation> GetCapabilityByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetCapabilityByLocation(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetUsage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetUsagesByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataLakeStoreUsage"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataLakeStoreUsage> GetUsagesByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetUsage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeStoreSubscriptionResource.GetUsagesByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DataLakeStoreUsage"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataLakeStoreUsage> GetUsagesByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataLakeStoreSubscriptionResource(subscriptionResource).GetUsagesByLocation(location, cancellationToken);
        }
    }
}
