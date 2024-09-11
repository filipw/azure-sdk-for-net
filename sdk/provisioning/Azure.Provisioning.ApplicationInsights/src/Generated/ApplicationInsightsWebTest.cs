// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// ApplicationInsightsWebTest.
/// </summary>
public partial class ApplicationInsightsWebTest : Resource
{
    /// <summary>
    /// The name of the Application Insights WebTest resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// User defined description for this WebTest.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// Interval in seconds between test runs for this WebTest. Default value
    /// is 300.
    /// </summary>
    public BicepValue<int> FrequencyInSeconds { get => _frequencyInSeconds; set => _frequencyInSeconds.Assign(value); }
    private readonly BicepValue<int> _frequencyInSeconds;

    /// <summary>
    /// Is the test actively being monitored.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Allow for retries should this WebTest fail.
    /// </summary>
    public BicepValue<bool> IsRetryEnabled { get => _isRetryEnabled; set => _isRetryEnabled.Assign(value); }
    private readonly BicepValue<bool> _isRetryEnabled;

    /// <summary>
    /// The kind of WebTest that this web test watches. Choices are ping,
    /// multistep and standard.
    /// </summary>
    public BicepValue<WebTestKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<WebTestKind> _kind;

    /// <summary>
    /// A list of where to physically run the tests from to give global
    /// coverage for accessibility of your application.
    /// </summary>
    public BicepList<WebTestGeolocation> Locations { get => _locations; set => _locations.Assign(value); }
    private readonly BicepList<WebTestGeolocation> _locations;

    /// <summary>
    /// The collection of request properties.
    /// </summary>
    public BicepValue<WebTestRequest> Request { get => _request; set => _request.Assign(value); }
    private readonly BicepValue<WebTestRequest> _request;

    /// <summary>
    /// Unique ID of this WebTest. This is typically the same value as the Name
    /// field.
    /// </summary>
    public BicepValue<string> SyntheticMonitorId { get => _syntheticMonitorId; set => _syntheticMonitorId.Assign(value); }
    private readonly BicepValue<string> _syntheticMonitorId;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Seconds until this WebTest will timeout and fail. Default value is 30.
    /// </summary>
    public BicepValue<int> TimeoutInSeconds { get => _timeoutInSeconds; set => _timeoutInSeconds.Assign(value); }
    private readonly BicepValue<int> _timeoutInSeconds;

    /// <summary>
    /// The collection of validation rule properties.
    /// </summary>
    public BicepValue<WebTestValidationRules> ValidationRules { get => _validationRules; set => _validationRules.Assign(value); }
    private readonly BicepValue<WebTestValidationRules> _validationRules;

    /// <summary>
    /// The XML specification of a WebTest to run against an application.
    /// </summary>
    public BicepValue<string> WebTest { get => _webTest; set => _webTest.Assign(value); }
    private readonly BicepValue<string> _webTest;

    /// <summary>
    /// The kind of web test this is, valid choices are ping, multistep and
    /// standard.
    /// </summary>
    public BicepValue<WebTestKind> WebTestKind { get => _webTestKind; set => _webTestKind.Assign(value); }
    private readonly BicepValue<WebTestKind> _webTestKind;

    /// <summary>
    /// User defined name if this WebTest.
    /// </summary>
    public BicepValue<string> WebTestName { get => _webTestName; set => _webTestName.Assign(value); }
    private readonly BicepValue<string> _webTestName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Current state of this component, whether or not is has been provisioned
    /// within the resource group it is defined. Users cannot change this
    /// value but are able to read from it. Values will include Succeeded,
    /// Deploying, Canceled, and Failed.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ApplicationInsightsWebTest.
    /// </summary>
    /// <param name="resourceName">Name of the ApplicationInsightsWebTest.</param>
    /// <param name="resourceVersion">Version of the ApplicationInsightsWebTest.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ApplicationInsightsWebTest(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Insights/webtests", resourceVersion ?? "2022-06-15", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "Description"]);
        _frequencyInSeconds = BicepValue<int>.DefineProperty(this, "FrequencyInSeconds", ["properties", "Frequency"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["properties", "Enabled"]);
        _isRetryEnabled = BicepValue<bool>.DefineProperty(this, "IsRetryEnabled", ["properties", "RetryEnabled"]);
        _kind = BicepValue<WebTestKind>.DefineProperty(this, "Kind", ["kind"]);
        _locations = BicepList<WebTestGeolocation>.DefineProperty(this, "Locations", ["properties", "Locations"]);
        _request = BicepValue<WebTestRequest>.DefineProperty(this, "Request", ["properties", "Request"]);
        _syntheticMonitorId = BicepValue<string>.DefineProperty(this, "SyntheticMonitorId", ["properties", "SyntheticMonitorId"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _timeoutInSeconds = BicepValue<int>.DefineProperty(this, "TimeoutInSeconds", ["properties", "Timeout"]);
        _validationRules = BicepValue<WebTestValidationRules>.DefineProperty(this, "ValidationRules", ["properties", "ValidationRules"]);
        _webTest = BicepValue<string>.DefineProperty(this, "WebTest", ["properties", "Configuration", "WebTest"]);
        _webTestKind = BicepValue<WebTestKind>.DefineProperty(this, "WebTestKind", ["properties", "Kind"]);
        _webTestName = BicepValue<string>.DefineProperty(this, "WebTestName", ["properties", "Name"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ApplicationInsightsWebTest resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2014-08-01.
        /// </summary>
        public static readonly string V2014_08_01 = "2014-08-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing ApplicationInsightsWebTest.
    /// </summary>
    /// <param name="resourceName">Name of the ApplicationInsightsWebTest.</param>
    /// <param name="resourceVersion">Version of the ApplicationInsightsWebTest.</param>
    /// <returns>The existing ApplicationInsightsWebTest resource.</returns>
    public static ApplicationInsightsWebTest FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
