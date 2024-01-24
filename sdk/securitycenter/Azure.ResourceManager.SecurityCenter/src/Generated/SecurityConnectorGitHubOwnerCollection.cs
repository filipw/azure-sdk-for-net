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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityConnectorGitHubOwnerResource"/> and their operations.
    /// Each <see cref="SecurityConnectorGitHubOwnerResource"/> in the collection will belong to the same instance of <see cref="DevOpsConfigurationResource"/>.
    /// To get a <see cref="SecurityConnectorGitHubOwnerCollection"/> instance call the GetSecurityConnectorGitHubOwners method from an instance of <see cref="DevOpsConfigurationResource"/>.
    /// </summary>
    public partial class SecurityConnectorGitHubOwnerCollection : ArmCollection, IEnumerable<SecurityConnectorGitHubOwnerResource>, IAsyncEnumerable<SecurityConnectorGitHubOwnerResource>
    {
        private readonly ClientDiagnostics _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics;
        private readonly GitHubOwnersRestOperations _securityConnectorGitHubOwnerGitHubOwnersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubOwnerCollection"/> class for mocking. </summary>
        protected SecurityConnectorGitHubOwnerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubOwnerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityConnectorGitHubOwnerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityConnectorGitHubOwnerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityConnectorGitHubOwnerResource.ResourceType, out string securityConnectorGitHubOwnerGitHubOwnersApiVersion);
            _securityConnectorGitHubOwnerGitHubOwnersRestClient = new GitHubOwnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorGitHubOwnerGitHubOwnersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevOpsConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevOpsConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual async Task<Response<SecurityConnectorGitHubOwnerResource>> GetAsync(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubOwnerGitHubOwnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual Response<SecurityConnectorGitHubOwnerResource> Get(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubOwnerGitHubOwnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of GitHub owners onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityConnectorGitHubOwnerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityConnectorGitHubOwnerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGitHubOwnerGitHubOwnersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGitHubOwnerGitHubOwnersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGitHubOwnerResource(Client, SecurityConnectorGitHubOwnerData.DeserializeSecurityConnectorGitHubOwnerData(e)), _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics, Pipeline, "SecurityConnectorGitHubOwnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of GitHub owners onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityConnectorGitHubOwnerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityConnectorGitHubOwnerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGitHubOwnerGitHubOwnersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGitHubOwnerGitHubOwnersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGitHubOwnerResource(Client, SecurityConnectorGitHubOwnerData.DeserializeSecurityConnectorGitHubOwnerData(e)), _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics, Pipeline, "SecurityConnectorGitHubOwnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubOwnerGitHubOwnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual Response<bool> Exists(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubOwnerGitHubOwnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityConnectorGitHubOwnerResource>> GetIfExistsAsync(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubOwnerGitHubOwnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorGitHubOwnerResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ownerName"/> is null. </exception>
        public virtual NullableResponse<SecurityConnectorGitHubOwnerResource> GetIfExists(string ownerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ownerName, nameof(ownerName));

            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubOwnerGitHubOwnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ownerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorGitHubOwnerResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityConnectorGitHubOwnerResource> IEnumerable<SecurityConnectorGitHubOwnerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityConnectorGitHubOwnerResource> IAsyncEnumerable<SecurityConnectorGitHubOwnerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
