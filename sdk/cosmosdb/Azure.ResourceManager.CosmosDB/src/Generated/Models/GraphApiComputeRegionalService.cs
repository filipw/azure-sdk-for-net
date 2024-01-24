// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Resource for a regional service location. </summary>
    public partial class GraphApiComputeRegionalService : CosmosDBRegionalService
    {
        /// <summary> Initializes a new instance of <see cref="GraphApiComputeRegionalService"/>. </summary>
        internal GraphApiComputeRegionalService()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GraphApiComputeRegionalService"/>. </summary>
        /// <param name="name"> The regional service name. </param>
        /// <param name="location"> The location name. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="graphApiComputeEndpoint"> The regional endpoint for GraphAPICompute. </param>
        internal GraphApiComputeRegionalService(string name, AzureLocation? location, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData, string graphApiComputeEndpoint) : base(name, location, status, serializedAdditionalRawData)
        {
            GraphApiComputeEndpoint = graphApiComputeEndpoint;
        }

        /// <summary> The regional endpoint for GraphAPICompute. </summary>
        public string GraphApiComputeEndpoint { get; }
    }
}
