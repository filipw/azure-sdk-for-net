// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights.Samples
{
    public partial class Sample_WorkspaceManagerConfigurationCollection
    {
        // Get all workspace manager configurations for a Sentinel workspace.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllWorkspaceManagerConfigurationsForASentinelWorkspace()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerConfigurations/GetAllWorkspaceManagerConfigurations.json
            // this example is just showing the usage of "WorkspaceManagerConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceSecurityInsightsResource created on azure
            // for more information of creating OperationalInsightsWorkspaceSecurityInsightsResource, please refer to the document of OperationalInsightsWorkspaceSecurityInsightsResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            ResourceIdentifier operationalInsightsWorkspaceSecurityInsightsResourceId = OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceSecurityInsightsResource operationalInsightsWorkspaceSecurityInsights = client.GetOperationalInsightsWorkspaceSecurityInsightsResource(operationalInsightsWorkspaceSecurityInsightsResourceId);

            // get the collection of this WorkspaceManagerConfigurationResource
            WorkspaceManagerConfigurationCollection collection = operationalInsightsWorkspaceSecurityInsights.GetWorkspaceManagerConfigurations();

            // invoke the operation and iterate over the result
            await foreach (WorkspaceManagerConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkspaceManagerConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a workspace manager configuration.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAWorkspaceManagerConfiguration()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerConfigurations/GetWorkspaceManagerConfiguration.json
            // this example is just showing the usage of "WorkspaceManagerConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceSecurityInsightsResource created on azure
            // for more information of creating OperationalInsightsWorkspaceSecurityInsightsResource, please refer to the document of OperationalInsightsWorkspaceSecurityInsightsResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            ResourceIdentifier operationalInsightsWorkspaceSecurityInsightsResourceId = OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceSecurityInsightsResource operationalInsightsWorkspaceSecurityInsights = client.GetOperationalInsightsWorkspaceSecurityInsightsResource(operationalInsightsWorkspaceSecurityInsightsResourceId);

            // get the collection of this WorkspaceManagerConfigurationResource
            WorkspaceManagerConfigurationCollection collection = operationalInsightsWorkspaceSecurityInsights.GetWorkspaceManagerConfigurations();

            // invoke the operation
            string workspaceManagerConfigurationName = "default";
            WorkspaceManagerConfigurationResource result = await collection.GetAsync(workspaceManagerConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkspaceManagerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a workspace manager configuration.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAWorkspaceManagerConfiguration()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerConfigurations/GetWorkspaceManagerConfiguration.json
            // this example is just showing the usage of "WorkspaceManagerConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceSecurityInsightsResource created on azure
            // for more information of creating OperationalInsightsWorkspaceSecurityInsightsResource, please refer to the document of OperationalInsightsWorkspaceSecurityInsightsResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            ResourceIdentifier operationalInsightsWorkspaceSecurityInsightsResourceId = OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceSecurityInsightsResource operationalInsightsWorkspaceSecurityInsights = client.GetOperationalInsightsWorkspaceSecurityInsightsResource(operationalInsightsWorkspaceSecurityInsightsResourceId);

            // get the collection of this WorkspaceManagerConfigurationResource
            WorkspaceManagerConfigurationCollection collection = operationalInsightsWorkspaceSecurityInsights.GetWorkspaceManagerConfigurations();

            // invoke the operation
            string workspaceManagerConfigurationName = "default";
            bool result = await collection.ExistsAsync(workspaceManagerConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a workspace manager configuration.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAWorkspaceManagerConfiguration()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerConfigurations/GetWorkspaceManagerConfiguration.json
            // this example is just showing the usage of "WorkspaceManagerConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceSecurityInsightsResource created on azure
            // for more information of creating OperationalInsightsWorkspaceSecurityInsightsResource, please refer to the document of OperationalInsightsWorkspaceSecurityInsightsResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            ResourceIdentifier operationalInsightsWorkspaceSecurityInsightsResourceId = OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceSecurityInsightsResource operationalInsightsWorkspaceSecurityInsights = client.GetOperationalInsightsWorkspaceSecurityInsightsResource(operationalInsightsWorkspaceSecurityInsightsResourceId);

            // get the collection of this WorkspaceManagerConfigurationResource
            WorkspaceManagerConfigurationCollection collection = operationalInsightsWorkspaceSecurityInsights.GetWorkspaceManagerConfigurations();

            // invoke the operation
            string workspaceManagerConfigurationName = "default";
            NullableResponse<WorkspaceManagerConfigurationResource> response = await collection.GetIfExistsAsync(workspaceManagerConfigurationName);
            WorkspaceManagerConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkspaceManagerConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or Update a workspace manager Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAWorkspaceManagerConfiguration()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerConfigurations/CreateOrUpdateWorkspaceManagerConfiguration.json
            // this example is just showing the usage of "WorkspaceManagerConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceSecurityInsightsResource created on azure
            // for more information of creating OperationalInsightsWorkspaceSecurityInsightsResource, please refer to the document of OperationalInsightsWorkspaceSecurityInsightsResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            ResourceIdentifier operationalInsightsWorkspaceSecurityInsightsResourceId = OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceSecurityInsightsResource operationalInsightsWorkspaceSecurityInsights = client.GetOperationalInsightsWorkspaceSecurityInsightsResource(operationalInsightsWorkspaceSecurityInsightsResourceId);

            // get the collection of this WorkspaceManagerConfigurationResource
            WorkspaceManagerConfigurationCollection collection = operationalInsightsWorkspaceSecurityInsights.GetWorkspaceManagerConfigurations();

            // invoke the operation
            string workspaceManagerConfigurationName = "default";
            WorkspaceManagerConfigurationData data = new WorkspaceManagerConfigurationData()
            {
                Mode = WorkspaceManagerConfigurationMode.Enabled,
            };
            ArmOperation<WorkspaceManagerConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceManagerConfigurationName, data);
            WorkspaceManagerConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkspaceManagerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
