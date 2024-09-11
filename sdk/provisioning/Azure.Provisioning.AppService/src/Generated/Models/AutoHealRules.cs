// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Rules that can be defined for auto-heal.
/// </summary>
public partial class AutoHealRules : ProvisioningConstruct
{
    /// <summary>
    /// Conditions that describe when to execute the auto-heal actions.
    /// </summary>
    public BicepValue<AutoHealTriggers> Triggers { get => _triggers; set => _triggers.Assign(value); }
    private readonly BicepValue<AutoHealTriggers> _triggers;

    /// <summary>
    /// Actions to be executed when a rule is triggered.
    /// </summary>
    public BicepValue<AutoHealActions> Actions { get => _actions; set => _actions.Assign(value); }
    private readonly BicepValue<AutoHealActions> _actions;

    /// <summary>
    /// Creates a new AutoHealRules.
    /// </summary>
    public AutoHealRules()
    {
        _triggers = BicepValue<AutoHealTriggers>.DefineProperty(this, "Triggers", ["triggers"]);
        _actions = BicepValue<AutoHealActions>.DefineProperty(this, "Actions", ["actions"]);
    }
}
