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
using Azure.ResourceManager.WebPubSub;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Samples
{
    public partial class Sample_WebPubSubPrivateEndpointConnectionCollection
    {
        // WebPubSubPrivateEndpointConnections_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WebPubSubPrivateEndpointConnectionsList()
        {
            // Generated from example definition: specification/webpubsub/resource-manager/Microsoft.SignalRService/stable/2021-10-01/examples/WebPubSubPrivateEndpointConnections_List.json
            // this example is just showing the usage of "WebPubSubPrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebPubSubResource created on azure
            // for more information of creating WebPubSubResource, please refer to the document of WebPubSubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myWebPubSubService";
            ResourceIdentifier webPubSubResourceId = WebPubSubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            WebPubSubResource webPubSub = client.GetWebPubSubResource(webPubSubResourceId);

            // get the collection of this WebPubSubPrivateEndpointConnectionResource
            WebPubSubPrivateEndpointConnectionCollection collection = webPubSub.GetWebPubSubPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (WebPubSubPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebPubSubPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WebPubSubPrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WebPubSubPrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/webpubsub/resource-manager/Microsoft.SignalRService/stable/2021-10-01/examples/WebPubSubPrivateEndpointConnections_Get.json
            // this example is just showing the usage of "WebPubSubPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebPubSubResource created on azure
            // for more information of creating WebPubSubResource, please refer to the document of WebPubSubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myWebPubSubService";
            ResourceIdentifier webPubSubResourceId = WebPubSubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            WebPubSubResource webPubSub = client.GetWebPubSubResource(webPubSubResourceId);

            // get the collection of this WebPubSubPrivateEndpointConnectionResource
            WebPubSubPrivateEndpointConnectionCollection collection = webPubSub.GetWebPubSubPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            WebPubSubPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebPubSubPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WebPubSubPrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WebPubSubPrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/webpubsub/resource-manager/Microsoft.SignalRService/stable/2021-10-01/examples/WebPubSubPrivateEndpointConnections_Get.json
            // this example is just showing the usage of "WebPubSubPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebPubSubResource created on azure
            // for more information of creating WebPubSubResource, please refer to the document of WebPubSubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myWebPubSubService";
            ResourceIdentifier webPubSubResourceId = WebPubSubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            WebPubSubResource webPubSub = client.GetWebPubSubResource(webPubSubResourceId);

            // get the collection of this WebPubSubPrivateEndpointConnectionResource
            WebPubSubPrivateEndpointConnectionCollection collection = webPubSub.GetWebPubSubPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WebPubSubPrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WebPubSubPrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/webpubsub/resource-manager/Microsoft.SignalRService/stable/2021-10-01/examples/WebPubSubPrivateEndpointConnections_Get.json
            // this example is just showing the usage of "WebPubSubPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebPubSubResource created on azure
            // for more information of creating WebPubSubResource, please refer to the document of WebPubSubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myWebPubSubService";
            ResourceIdentifier webPubSubResourceId = WebPubSubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            WebPubSubResource webPubSub = client.GetWebPubSubResource(webPubSubResourceId);

            // get the collection of this WebPubSubPrivateEndpointConnectionResource
            WebPubSubPrivateEndpointConnectionCollection collection = webPubSub.GetWebPubSubPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            NullableResponse<WebPubSubPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            WebPubSubPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebPubSubPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // WebPubSubPrivateEndpointConnections_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WebPubSubPrivateEndpointConnectionsUpdate()
        {
            // Generated from example definition: specification/webpubsub/resource-manager/Microsoft.SignalRService/stable/2021-10-01/examples/WebPubSubPrivateEndpointConnections_Update.json
            // this example is just showing the usage of "WebPubSubPrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebPubSubResource created on azure
            // for more information of creating WebPubSubResource, please refer to the document of WebPubSubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myWebPubSubService";
            ResourceIdentifier webPubSubResourceId = WebPubSubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            WebPubSubResource webPubSub = client.GetWebPubSubResource(webPubSubResourceId);

            // get the collection of this WebPubSubPrivateEndpointConnectionResource
            WebPubSubPrivateEndpointConnectionCollection collection = webPubSub.GetWebPubSubPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "mywebpubsubservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            WebPubSubPrivateEndpointConnectionData data = new WebPubSubPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/Microsoft.Network/privateEndpoints/myPrivateEndpoint"),
                ConnectionState = new WebPubSubPrivateLinkServiceConnectionState()
                {
                    Status = WebPubSubPrivateLinkServiceConnectionStatus.Approved,
                    ActionsRequired = "None",
                },
            };
            ArmOperation<WebPubSubPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            WebPubSubPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebPubSubPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
