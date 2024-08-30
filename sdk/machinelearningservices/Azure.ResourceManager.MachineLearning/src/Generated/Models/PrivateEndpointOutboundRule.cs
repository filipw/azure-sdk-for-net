// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Private Endpoint Outbound Rule for the managed network of a machine learning workspace. </summary>
    public partial class PrivateEndpointOutboundRule : MachineLearningOutboundRule
    {
        /// <summary> Initializes a new instance of <see cref="PrivateEndpointOutboundRule"/>. </summary>
        public PrivateEndpointOutboundRule()
        {
            Fqdns = new ChangeTrackingList<string>();
            OutboundRuleType = OutboundRuleType.PrivateEndpoint;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointOutboundRule"/>. </summary>
        /// <param name="category"> Category of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="parentRuleNames"></param>
        /// <param name="status"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="outboundRuleType"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="destination"> Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace. </param>
        /// <param name="fqdns"></param>
        internal PrivateEndpointOutboundRule(OutboundRuleCategory? category, IReadOnlyList<string> parentRuleNames, OutboundRuleStatus? status, OutboundRuleType outboundRuleType, IDictionary<string, BinaryData> serializedAdditionalRawData, PrivateEndpointDestination destination, IList<string> fqdns) : base(category, parentRuleNames, status, outboundRuleType, serializedAdditionalRawData)
        {
            Destination = destination;
            Fqdns = fqdns;
            OutboundRuleType = outboundRuleType;
        }

        /// <summary> Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace. </summary>
        [WirePath("destination")]
        public PrivateEndpointDestination Destination { get; set; }
        /// <summary> Gets the fqdns. </summary>
        [WirePath("fqdns")]
        public IList<string> Fqdns { get; }
    }
}
