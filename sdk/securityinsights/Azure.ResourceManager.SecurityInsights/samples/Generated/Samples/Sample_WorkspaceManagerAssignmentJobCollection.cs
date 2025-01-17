// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SecurityInsights.Samples
{
    public partial class Sample_WorkspaceManagerAssignmentJobCollection
    {
        // Get all jobs for the specified Sentinel workspace manager assignment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllJobsForTheSpecifiedSentinelWorkspaceManagerAssignment()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerAssignments/GetAllJobs.json
            // this example is just showing the usage of "WorkspaceManagerAssignmentJobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceManagerAssignmentResource created on azure
            // for more information of creating WorkspaceManagerAssignmentResource, please refer to the document of WorkspaceManagerAssignmentResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string workspaceManagerAssignmentName = "47cdc5f5-37c4-47b5-bd5f-83c84b8bdd58";
            ResourceIdentifier workspaceManagerAssignmentResourceId = WorkspaceManagerAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, workspaceManagerAssignmentName);
            WorkspaceManagerAssignmentResource workspaceManagerAssignment = client.GetWorkspaceManagerAssignmentResource(workspaceManagerAssignmentResourceId);

            // get the collection of this WorkspaceManagerAssignmentJobResource
            WorkspaceManagerAssignmentJobCollection collection = workspaceManagerAssignment.GetWorkspaceManagerAssignmentJobs();

            // invoke the operation and iterate over the result
            await foreach (WorkspaceManagerAssignmentJobResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkspaceManagerAssignmentJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a workspace manager job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAWorkspaceManagerJob()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerAssignments/GetJob.json
            // this example is just showing the usage of "WorkspaceManagerAssignmentJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceManagerAssignmentResource created on azure
            // for more information of creating WorkspaceManagerAssignmentResource, please refer to the document of WorkspaceManagerAssignmentResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string workspaceManagerAssignmentName = "47cdc5f5-37c4-47b5-bd5f-83c84b8bdd58";
            ResourceIdentifier workspaceManagerAssignmentResourceId = WorkspaceManagerAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, workspaceManagerAssignmentName);
            WorkspaceManagerAssignmentResource workspaceManagerAssignment = client.GetWorkspaceManagerAssignmentResource(workspaceManagerAssignmentResourceId);

            // get the collection of this WorkspaceManagerAssignmentJobResource
            WorkspaceManagerAssignmentJobCollection collection = workspaceManagerAssignment.GetWorkspaceManagerAssignmentJobs();

            // invoke the operation
            string jobName = "cfbe1338-8276-4d5d-8b96-931117f9fa0e";
            WorkspaceManagerAssignmentJobResource result = await collection.GetAsync(jobName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkspaceManagerAssignmentJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a workspace manager job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAWorkspaceManagerJob()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerAssignments/GetJob.json
            // this example is just showing the usage of "WorkspaceManagerAssignmentJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceManagerAssignmentResource created on azure
            // for more information of creating WorkspaceManagerAssignmentResource, please refer to the document of WorkspaceManagerAssignmentResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string workspaceManagerAssignmentName = "47cdc5f5-37c4-47b5-bd5f-83c84b8bdd58";
            ResourceIdentifier workspaceManagerAssignmentResourceId = WorkspaceManagerAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, workspaceManagerAssignmentName);
            WorkspaceManagerAssignmentResource workspaceManagerAssignment = client.GetWorkspaceManagerAssignmentResource(workspaceManagerAssignmentResourceId);

            // get the collection of this WorkspaceManagerAssignmentJobResource
            WorkspaceManagerAssignmentJobCollection collection = workspaceManagerAssignment.GetWorkspaceManagerAssignmentJobs();

            // invoke the operation
            string jobName = "cfbe1338-8276-4d5d-8b96-931117f9fa0e";
            bool result = await collection.ExistsAsync(jobName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a workspace manager job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAWorkspaceManagerJob()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/workspaceManagerAssignments/GetJob.json
            // this example is just showing the usage of "WorkspaceManagerAssignmentJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceManagerAssignmentResource created on azure
            // for more information of creating WorkspaceManagerAssignmentResource, please refer to the document of WorkspaceManagerAssignmentResource
            string subscriptionId = "d0cfe6b2-9ac0-4464-9919-dccaee2e48c0";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string workspaceManagerAssignmentName = "47cdc5f5-37c4-47b5-bd5f-83c84b8bdd58";
            ResourceIdentifier workspaceManagerAssignmentResourceId = WorkspaceManagerAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, workspaceManagerAssignmentName);
            WorkspaceManagerAssignmentResource workspaceManagerAssignment = client.GetWorkspaceManagerAssignmentResource(workspaceManagerAssignmentResourceId);

            // get the collection of this WorkspaceManagerAssignmentJobResource
            WorkspaceManagerAssignmentJobCollection collection = workspaceManagerAssignment.GetWorkspaceManagerAssignmentJobs();

            // invoke the operation
            string jobName = "cfbe1338-8276-4d5d-8b96-931117f9fa0e";
            NullableResponse<WorkspaceManagerAssignmentJobResource> response = await collection.GetIfExistsAsync(jobName);
            WorkspaceManagerAssignmentJobResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkspaceManagerAssignmentJobData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
