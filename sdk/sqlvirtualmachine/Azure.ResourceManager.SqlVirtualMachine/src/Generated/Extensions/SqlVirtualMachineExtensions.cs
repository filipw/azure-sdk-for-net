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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SqlVirtualMachine.Mocking;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SqlVirtualMachine. </summary>
    public static partial class SqlVirtualMachineExtensions
    {
        private static MockableSqlVirtualMachineArmClient GetMockableSqlVirtualMachineArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableSqlVirtualMachineArmClient(client0));
        }

        private static MockableSqlVirtualMachineResourceGroupResource GetMockableSqlVirtualMachineResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSqlVirtualMachineResourceGroupResource(client, resource.Id));
        }

        private static MockableSqlVirtualMachineSubscriptionResource GetMockableSqlVirtualMachineSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSqlVirtualMachineSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailabilityGroupListenerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilityGroupListenerResource.CreateResourceIdentifier" /> to create an <see cref="AvailabilityGroupListenerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineArmClient.GetAvailabilityGroupListenerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AvailabilityGroupListenerResource" /> object. </returns>
        public static AvailabilityGroupListenerResource GetAvailabilityGroupListenerResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSqlVirtualMachineArmClient(client).GetAvailabilityGroupListenerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SqlVmGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SqlVmGroupResource.CreateResourceIdentifier" /> to create a <see cref="SqlVmGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineArmClient.GetSqlVmGroupResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SqlVmGroupResource" /> object. </returns>
        public static SqlVmGroupResource GetSqlVmGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSqlVirtualMachineArmClient(client).GetSqlVmGroupResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SqlVmResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SqlVmResource.CreateResourceIdentifier" /> to create a <see cref="SqlVmResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineArmClient.GetSqlVmResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SqlVmResource" /> object. </returns>
        public static SqlVmResource GetSqlVmResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSqlVirtualMachineArmClient(client).GetSqlVmResource(id);
        }

        /// <summary>
        /// Gets a collection of SqlVmGroupResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVmGroups()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of SqlVmGroupResources and their operations over a SqlVmGroupResource. </returns>
        public static SqlVmGroupCollection GetSqlVmGroups(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVmGroups();
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVmGroupAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="sqlVmGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SqlVmGroupResource>> GetSqlVmGroupAsync(this ResourceGroupResource resourceGroupResource, string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVmGroupAsync(sqlVmGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVmGroup(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="sqlVmGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<SqlVmGroupResource> GetSqlVmGroup(this ResourceGroupResource resourceGroupResource, string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVmGroup(sqlVmGroupName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of SqlVmResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVms()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of SqlVmResources and their operations over a SqlVmResource. </returns>
        public static SqlVmCollection GetSqlVms(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVms();
        }

        /// <summary>
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVmAsync(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="sqlVmName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SqlVmResource>> GetSqlVmAsync(this ResourceGroupResource resourceGroupResource, string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVmAsync(sqlVmName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineResourceGroupResource.GetSqlVm(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="sqlVmName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<SqlVmResource> GetSqlVm(this ResourceGroupResource resourceGroupResource, string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableSqlVirtualMachineResourceGroupResource(resourceGroupResource).GetSqlVm(sqlVmName, expand, cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineSubscriptionResource.GetSqlVmGroups(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="SqlVmGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SqlVmGroupResource> GetSqlVmGroupsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSqlVirtualMachineSubscriptionResource(subscriptionResource).GetSqlVmGroupsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineSubscriptionResource.GetSqlVmGroups(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="SqlVmGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SqlVmGroupResource> GetSqlVmGroups(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSqlVirtualMachineSubscriptionResource(subscriptionResource).GetSqlVmGroups(cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machines in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineSubscriptionResource.GetSqlVms(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="SqlVmResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SqlVmResource> GetSqlVmsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSqlVirtualMachineSubscriptionResource(subscriptionResource).GetSqlVmsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machines in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSqlVirtualMachineSubscriptionResource.GetSqlVms(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="SqlVmResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SqlVmResource> GetSqlVms(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSqlVirtualMachineSubscriptionResource(subscriptionResource).GetSqlVms(cancellationToken);
        }
    }
}
