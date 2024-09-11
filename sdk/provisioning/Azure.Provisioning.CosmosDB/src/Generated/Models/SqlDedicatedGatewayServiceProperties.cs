// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Properties for SqlDedicatedGatewayServiceResource.
/// </summary>
public partial class SqlDedicatedGatewayServiceProperties : CosmosDBServiceProperties
{
    /// <summary>
    /// SqlDedicatedGateway endpoint for the service.
    /// </summary>
    public BicepValue<string> SqlDedicatedGatewayEndpoint { get => _sqlDedicatedGatewayEndpoint; set => _sqlDedicatedGatewayEndpoint.Assign(value); }
    private readonly BicepValue<string> _sqlDedicatedGatewayEndpoint;

    /// <summary>
    /// An array that contains all of the locations for the service.
    /// </summary>
    public BicepList<SqlDedicatedGatewayRegionalService> Locations { get => _locations; }
    private readonly BicepList<SqlDedicatedGatewayRegionalService> _locations;

    /// <summary>
    /// Creates a new SqlDedicatedGatewayServiceProperties.
    /// </summary>
    public SqlDedicatedGatewayServiceProperties() : base()
    {
        BicepValue<string>.DefineProperty(this, "serviceType", ["serviceType"], defaultValue: "SqlDedicatedGateway");
        _sqlDedicatedGatewayEndpoint = BicepValue<string>.DefineProperty(this, "SqlDedicatedGatewayEndpoint", ["sqlDedicatedGatewayEndpoint"]);
        _locations = BicepList<SqlDedicatedGatewayRegionalService>.DefineProperty(this, "Locations", ["locations"], isOutput: true);
    }
}
