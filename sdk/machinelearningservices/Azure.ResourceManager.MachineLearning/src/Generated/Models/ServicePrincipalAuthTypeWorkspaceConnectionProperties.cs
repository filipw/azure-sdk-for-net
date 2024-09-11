// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ServicePrincipalAuthTypeWorkspaceConnectionProperties. </summary>
    public partial class ServicePrincipalAuthTypeWorkspaceConnectionProperties : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalAuthTypeWorkspaceConnectionProperties"/>. </summary>
        public ServicePrincipalAuthTypeWorkspaceConnectionProperties()
        {
            AuthType = MachineLearningConnectionAuthType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalAuthTypeWorkspaceConnectionProperties"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="createdByWorkspaceArmId"></param>
        /// <param name="expiryOn"></param>
        /// <param name="group"> Group based on connection category. </param>
        /// <param name="isSharedToAll"></param>
        /// <param name="target"></param>
        /// <param name="metadata"> Store user metadata for this connection. </param>
        /// <param name="sharedUserList"></param>
        /// <param name="value"> Value details of the workspace connection. </param>
        /// <param name="valueFormat"> format for the workspace connection value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials"></param>
        internal ServicePrincipalAuthTypeWorkspaceConnectionProperties(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, ResourceIdentifier createdByWorkspaceArmId, DateTimeOffset? expiryOn, WorkspaceConnectionGroup? group, bool? isSharedToAll, string target, IDictionary<string, string> metadata, IList<string> sharedUserList, string value, MachineLearningValueFormat? valueFormat, IDictionary<string, BinaryData> serializedAdditionalRawData, WorkspaceConnectionServicePrincipal credentials) : base(authType, category, createdByWorkspaceArmId, expiryOn, group, isSharedToAll, target, metadata, sharedUserList, value, valueFormat, serializedAdditionalRawData)
        {
            Credentials = credentials;
            AuthType = authType;
        }

        /// <summary> Gets or sets the credentials. </summary>
        [WirePath("credentials")]
        public WorkspaceConnectionServicePrincipal Credentials { get; set; }
    }
}
