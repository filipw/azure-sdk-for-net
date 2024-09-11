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
    public partial class Sample_SecurityInsightsThreatIntelligenceIndicatorResource
    {
        // View a threat intelligence indicator by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ViewAThreatIntelligenceIndicatorByName()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/threatintelligence/GetThreatIntelligenceById.json
            // this example is just showing the usage of "ThreatIntelligenceIndicators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsThreatIntelligenceIndicatorResource created on azure
            // for more information of creating SecurityInsightsThreatIntelligenceIndicatorResource, please refer to the document of SecurityInsightsThreatIntelligenceIndicatorResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string name = "e16ef847-962e-d7b6-9c8b-a33e4bd30e47";
            ResourceIdentifier securityInsightsThreatIntelligenceIndicatorResourceId = SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            SecurityInsightsThreatIntelligenceIndicatorResource securityInsightsThreatIntelligenceIndicator = client.GetSecurityInsightsThreatIntelligenceIndicatorResource(securityInsightsThreatIntelligenceIndicatorResourceId);

            // invoke the operation
            SecurityInsightsThreatIntelligenceIndicatorResource result = await securityInsightsThreatIntelligenceIndicator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsThreatIntelligenceIndicatorBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a threat Intelligence indicator
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAThreatIntelligenceIndicator()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/threatintelligence/UpdateThreatIntelligence.json
            // this example is just showing the usage of "ThreatIntelligenceIndicators_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsThreatIntelligenceIndicatorResource created on azure
            // for more information of creating SecurityInsightsThreatIntelligenceIndicatorResource, please refer to the document of SecurityInsightsThreatIntelligenceIndicatorResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string name = "d9cd6f0b-96b9-3984-17cd-a779d1e15a93";
            ResourceIdentifier securityInsightsThreatIntelligenceIndicatorResourceId = SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            SecurityInsightsThreatIntelligenceIndicatorResource securityInsightsThreatIntelligenceIndicator = client.GetSecurityInsightsThreatIntelligenceIndicatorResource(securityInsightsThreatIntelligenceIndicatorResourceId);

            // invoke the operation
            SecurityInsightsThreatIntelligenceIndicatorData content = new SecurityInsightsThreatIntelligenceIndicatorData()
            {
                ThreatIntelligenceTags =
{
"new schema"
},
                Source = "Azure Sentinel",
                DisplayName = "new schema",
                Description = "debugging indicators",
                Pattern = "[url:value = 'https://www.contoso.com']",
                PatternType = "url",
                KillChainPhases =
{
},
                CreatedByRef = "contoso@contoso.com",
                ExternalReferences =
{
},
                GranularMarkings =
{
},
                Labels =
{
},
                IsRevoked = false,
                Confidence = 78,
                ThreatTypes =
{
"compromised"
},
                ValidFrom = DateTimeOffset.Parse("2020-04-15T17:44:00.114052Z"),
                ValidUntil = DateTimeOffset.Parse(""),
                Modified = "",
            };
            ArmOperation<SecurityInsightsThreatIntelligenceIndicatorResource> lro = await securityInsightsThreatIntelligenceIndicator.UpdateAsync(WaitUntil.Completed, content);
            SecurityInsightsThreatIntelligenceIndicatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityInsightsThreatIntelligenceIndicatorBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a threat intelligence indicator
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAThreatIntelligenceIndicator()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/threatintelligence/DeleteThreatIntelligence.json
            // this example is just showing the usage of "ThreatIntelligenceIndicators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsThreatIntelligenceIndicatorResource created on azure
            // for more information of creating SecurityInsightsThreatIntelligenceIndicatorResource, please refer to the document of SecurityInsightsThreatIntelligenceIndicatorResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string name = "d9cd6f0b-96b9-3984-17cd-a779d1e15a93";
            ResourceIdentifier securityInsightsThreatIntelligenceIndicatorResourceId = SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            SecurityInsightsThreatIntelligenceIndicatorResource securityInsightsThreatIntelligenceIndicator = client.GetSecurityInsightsThreatIntelligenceIndicatorResource(securityInsightsThreatIntelligenceIndicatorResourceId);

            // invoke the operation
            await securityInsightsThreatIntelligenceIndicator.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Append tags to a threat intelligence indicator
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task AppendTags_AppendTagsToAThreatIntelligenceIndicator()
        {
            // Generated from example definition: specification/securityinsights/resource-manager/Microsoft.SecurityInsights/preview/2024-01-01-preview/examples/threatintelligence/AppendTagsThreatIntelligence.json
            // this example is just showing the usage of "ThreatIntelligenceIndicators_AppendTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityInsightsThreatIntelligenceIndicatorResource created on azure
            // for more information of creating SecurityInsightsThreatIntelligenceIndicatorResource, please refer to the document of SecurityInsightsThreatIntelligenceIndicatorResource
            string subscriptionId = "bd794837-4d29-4647-9105-6339bfdb4e6a";
            string resourceGroupName = "myRg";
            string workspaceName = "myWorkspace";
            string name = "d9cd6f0b-96b9-3984-17cd-a779d1e15a93";
            ResourceIdentifier securityInsightsThreatIntelligenceIndicatorResourceId = SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            SecurityInsightsThreatIntelligenceIndicatorResource securityInsightsThreatIntelligenceIndicator = client.GetSecurityInsightsThreatIntelligenceIndicatorResource(securityInsightsThreatIntelligenceIndicatorResourceId);

            // invoke the operation
            ThreatIntelligenceAppendTags threatIntelligenceAppendTags = new ThreatIntelligenceAppendTags()
            {
                ThreatIntelligenceTags =
{
"tag1","tag2"
},
            };
            await securityInsightsThreatIntelligenceIndicator.AppendTagsAsync(threatIntelligenceAppendTags);

            Console.WriteLine($"Succeeded");
        }
    }
}
