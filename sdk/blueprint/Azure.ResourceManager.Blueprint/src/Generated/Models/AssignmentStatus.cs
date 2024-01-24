// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> The status of a blueprint assignment. This field is readonly. </summary>
    public partial class AssignmentStatus : BlueprintResourceStatusBase
    {
        /// <summary> Initializes a new instance of <see cref="AssignmentStatus"/>. </summary>
        internal AssignmentStatus()
        {
            ManagedResources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AssignmentStatus"/>. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="managedResources"> List of resources that were created by the blueprint assignment. </param>
        internal AssignmentStatus(DateTimeOffset? timeCreated, DateTimeOffset? lastModified, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<string> managedResources) : base(timeCreated, lastModified, serializedAdditionalRawData)
        {
            ManagedResources = managedResources;
        }

        /// <summary> List of resources that were created by the blueprint assignment. </summary>
        public IReadOnlyList<string> ManagedResources { get; }
    }
}
