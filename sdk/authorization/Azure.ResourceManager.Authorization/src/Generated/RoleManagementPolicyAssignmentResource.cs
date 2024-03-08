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

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing a RoleManagementPolicyAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RoleManagementPolicyAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRoleManagementPolicyAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetRoleManagementPolicyAssignment method.
    /// </summary>
    public partial class RoleManagementPolicyAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleManagementPolicyAssignmentResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The roleManagementPolicyAssignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleManagementPolicyAssignmentName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleManagementPolicyAssignmentClientDiagnostics;
        private readonly RoleManagementPolicyAssignmentsRestOperations _roleManagementPolicyAssignmentRestClient;
        private readonly RoleManagementPolicyAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleManagementPolicyAssignments";

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyAssignmentResource"/> class for mocking. </summary>
        protected RoleManagementPolicyAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleManagementPolicyAssignmentResource(ArmClient client, RoleManagementPolicyAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleManagementPolicyAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleManagementPolicyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleManagementPolicyAssignmentApiVersion);
            _roleManagementPolicyAssignmentRestClient = new RoleManagementPolicyAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleManagementPolicyAssignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleManagementPolicyAssignmentData Data
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
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleManagementPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleManagementPolicyAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleManagementPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleManagementPolicyAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a role management policy assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleManagementPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleManagementPolicyAssignmentResource>> UpdateAsync(WaitUntil waitUntil, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleManagementPolicyAssignmentResource>(Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Create a role management policy assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleManagementPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleManagementPolicyAssignmentResource> Update(WaitUntil waitUntil, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleManagementPolicyAssignmentResource>(Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
    }
}
