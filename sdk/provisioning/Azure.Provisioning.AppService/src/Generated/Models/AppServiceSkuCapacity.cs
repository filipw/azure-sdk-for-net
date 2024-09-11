// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Description of the App Service plan scale options.
/// </summary>
public partial class AppServiceSkuCapacity : ProvisioningConstruct
{
    /// <summary>
    /// Minimum number of workers for this App Service plan SKU.
    /// </summary>
    public BicepValue<int> Minimum { get => _minimum; set => _minimum.Assign(value); }
    private readonly BicepValue<int> _minimum;

    /// <summary>
    /// Maximum number of workers for this App Service plan SKU.
    /// </summary>
    public BicepValue<int> Maximum { get => _maximum; set => _maximum.Assign(value); }
    private readonly BicepValue<int> _maximum;

    /// <summary>
    /// Maximum number of Elastic workers for this App Service plan SKU.
    /// </summary>
    public BicepValue<int> ElasticMaximum { get => _elasticMaximum; set => _elasticMaximum.Assign(value); }
    private readonly BicepValue<int> _elasticMaximum;

    /// <summary>
    /// Default number of workers for this App Service plan SKU.
    /// </summary>
    public BicepValue<int> Default { get => _default; set => _default.Assign(value); }
    private readonly BicepValue<int> _default;

    /// <summary>
    /// Available scale configurations for an App Service plan.
    /// </summary>
    public BicepValue<string> ScaleType { get => _scaleType; set => _scaleType.Assign(value); }
    private readonly BicepValue<string> _scaleType;

    /// <summary>
    /// Creates a new AppServiceSkuCapacity.
    /// </summary>
    public AppServiceSkuCapacity()
    {
        _minimum = BicepValue<int>.DefineProperty(this, "Minimum", ["minimum"]);
        _maximum = BicepValue<int>.DefineProperty(this, "Maximum", ["maximum"]);
        _elasticMaximum = BicepValue<int>.DefineProperty(this, "ElasticMaximum", ["elasticMaximum"]);
        _default = BicepValue<int>.DefineProperty(this, "Default", ["default"]);
        _scaleType = BicepValue<string>.DefineProperty(this, "ScaleType", ["scaleType"]);
    }
}
