// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> A Microsoft Teams user. </summary>
    public partial class MicrosoftTeamsUserIdentifierModel
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        internal MicrosoftTeamsUserIdentifierModel(string userId)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            UserId = userId;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <param name="isAnonymous"> True if the Microsoft Teams user is anonymous. By default false if missing. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </param>
        internal MicrosoftTeamsUserIdentifierModel(string userId, bool? isAnonymous, CommunicationCloudEnvironmentModel? cloud)
        {
            UserId = userId;
            IsAnonymous = isAnonymous;
            Cloud = cloud;
        }

        /// <summary> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </summary>
        public string UserId { get; }
        /// <summary> True if the Microsoft Teams user is anonymous. By default false if missing. </summary>
        public bool? IsAnonymous { get; }
        /// <summary> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </summary>
        public CommunicationCloudEnvironmentModel? Cloud { get; }
    }
}
