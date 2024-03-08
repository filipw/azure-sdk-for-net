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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a HostingEnvironmentRecommendation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HostingEnvironmentRecommendationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHostingEnvironmentRecommendationResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceEnvironmentResource"/> using the GetHostingEnvironmentRecommendation method.
    /// </summary>
    public partial class HostingEnvironmentRecommendationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentRecommendationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hostingEnvironmentName"> The hostingEnvironmentName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostingEnvironmentName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentRecommendationRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _hostingEnvironmentRecommendationRecommendationsRestClient;
        private readonly RecommendationRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/recommendations";

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationResource"/> class for mocking. </summary>
        protected HostingEnvironmentRecommendationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentRecommendationResource(ArmClient client, RecommendationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentRecommendationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentRecommendationRecommendationsApiVersion);
            _hostingEnvironmentRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentRecommendationRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecommendationRuleData Data
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
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HostingEnvironmentRecommendationResource>> GetAsync(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentRecommendationResource> Get(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Disables the specific rule for a web site permanently.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_DisableRecommendationForHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Site name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response> DisableRecommendationForHostingEnvironmentAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(environmentName, nameof(environmentName));

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.DisableRecommendationForHostingEnvironment");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.DisableRecommendationForHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, environmentName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Disables the specific rule for a web site permanently.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_DisableRecommendationForHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Site name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response DisableRecommendationForHostingEnvironment(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(environmentName, nameof(environmentName));

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.DisableRecommendationForHostingEnvironment");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.DisableRecommendationForHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, environmentName, cancellationToken);
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
