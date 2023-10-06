// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceNetworking;
using Azure.ResourceManager.ServiceNetworking.Models;

namespace Azure.ResourceManager.ServiceNetworking.Samples
{
    public partial class Sample_TrafficControllerResource
    {
        // Get Traffic Controllers List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTrafficControllers_GetTrafficControllersList()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/TrafficControllersGetList.json
            // this example is just showing the usage of "TrafficControllerInterface_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (TrafficControllerResource item in subscriptionResource.GetTrafficControllersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TrafficControllerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Traffic Controller
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTrafficController()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/TrafficControllerGet.json
            // this example is just showing the usage of "TrafficControllerInterface_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficControllerResource created on azure
            // for more information of creating TrafficControllerResource, please refer to the document of TrafficControllerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            ResourceIdentifier trafficControllerResourceId = TrafficControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName);
            TrafficControllerResource trafficController = client.GetTrafficControllerResource(trafficControllerResourceId);

            // invoke the operation
            TrafficControllerResource result = await trafficController.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch Traffic Controller
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchTrafficController()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/TrafficControllerPatch.json
            // this example is just showing the usage of "TrafficControllerInterface_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficControllerResource created on azure
            // for more information of creating TrafficControllerResource, please refer to the document of TrafficControllerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            ResourceIdentifier trafficControllerResourceId = TrafficControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName);
            TrafficControllerResource trafficController = client.GetTrafficControllerResource(trafficControllerResourceId);

            // invoke the operation
            TrafficControllerPatch patch = new TrafficControllerPatch()
            {
                Tags =
{
["key1"] = "value1",
},
            };
            TrafficControllerResource result = await trafficController.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Traffic Controller
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteTrafficController()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/TrafficControllerDelete.json
            // this example is just showing the usage of "TrafficControllerInterface_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficControllerResource created on azure
            // for more information of creating TrafficControllerResource, please refer to the document of TrafficControllerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            ResourceIdentifier trafficControllerResourceId = TrafficControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName);
            TrafficControllerResource trafficController = client.GetTrafficControllerResource(trafficControllerResourceId);

            // invoke the operation
            await trafficController.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
