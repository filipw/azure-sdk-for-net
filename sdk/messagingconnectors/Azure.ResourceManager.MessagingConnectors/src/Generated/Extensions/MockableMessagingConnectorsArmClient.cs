// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MessagingConnectors;

namespace Azure.ResourceManager.MessagingConnectors.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMessagingConnectorsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMessagingConnectorsArmClient"/> class for mocking. </summary>
        protected MockableMessagingConnectorsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMessagingConnectorsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMessagingConnectorsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMessagingConnectorsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorInstanceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorInstanceResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorInstanceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorInstanceResource"/> object. </returns>
        public virtual ConnectorInstanceResource GetConnectorInstanceResource(ResourceIdentifier id)
        {
            ConnectorInstanceResource.ValidateResourceId(id);
            return new ConnectorInstanceResource(Client, id);
        }
    }
}
