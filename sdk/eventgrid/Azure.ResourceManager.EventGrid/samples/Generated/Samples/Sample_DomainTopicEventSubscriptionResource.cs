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
using Azure.ResourceManager.EventGrid;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_DomainTopicEventSubscriptionResource
    {
        // DomainTopicEventSubscriptions_GetDeliveryAttributes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDeliveryAttributes_DomainTopicEventSubscriptionsGetDeliveryAttributes()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/DomainTopicEventSubscriptions_GetDeliveryAttributes.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_GetDeliveryAttributes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicEventSubscriptionResource created on azure
            // for more information of creating DomainTopicEventSubscriptionResource, please refer to the document of DomainTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier domainTopicEventSubscriptionResourceId = DomainTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName, eventSubscriptionName);
            DomainTopicEventSubscriptionResource domainTopicEventSubscription = client.GetDomainTopicEventSubscriptionResource(domainTopicEventSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DeliveryAttributeMapping item in domainTopicEventSubscription.GetDeliveryAttributesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DomainTopicEventSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DomainTopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/DomainTopicEventSubscriptions_Get.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicEventSubscriptionResource created on azure
            // for more information of creating DomainTopicEventSubscriptionResource, please refer to the document of DomainTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier domainTopicEventSubscriptionResourceId = DomainTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName, eventSubscriptionName);
            DomainTopicEventSubscriptionResource domainTopicEventSubscription = client.GetDomainTopicEventSubscriptionResource(domainTopicEventSubscriptionResourceId);

            // invoke the operation
            DomainTopicEventSubscriptionResource result = await domainTopicEventSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopicEventSubscriptions_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DomainTopicEventSubscriptionsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/DomainTopicEventSubscriptions_Delete.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicEventSubscriptionResource created on azure
            // for more information of creating DomainTopicEventSubscriptionResource, please refer to the document of DomainTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier domainTopicEventSubscriptionResourceId = DomainTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName, eventSubscriptionName);
            DomainTopicEventSubscriptionResource domainTopicEventSubscription = client.GetDomainTopicEventSubscriptionResource(domainTopicEventSubscriptionResourceId);

            // invoke the operation
            await domainTopicEventSubscription.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // DomainTopicEventSubscriptions_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DomainTopicEventSubscriptionsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/DomainTopicEventSubscriptions_Update.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicEventSubscriptionResource created on azure
            // for more information of creating DomainTopicEventSubscriptionResource, please refer to the document of DomainTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "exampleEventSubscriptionName1";
            ResourceIdentifier domainTopicEventSubscriptionResourceId = DomainTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName, eventSubscriptionName);
            DomainTopicEventSubscriptionResource domainTopicEventSubscription = client.GetDomainTopicEventSubscriptionResource(domainTopicEventSubscriptionResourceId);

            // invoke the operation
            EventGridSubscriptionPatch patch = new EventGridSubscriptionPatch()
            {
                Destination = new WebHookEventSubscriptionDestination()
                {
                    Endpoint = new Uri("https://requestb.in/15ksip71"),
                },
                Filter = new EventSubscriptionFilter()
                {
                    SubjectBeginsWith = "existingPrefix",
                    SubjectEndsWith = "newSuffix",
                    IsSubjectCaseSensitive = true,
                },
                Labels =
{
"label1","label2"
},
            };
            ArmOperation<DomainTopicEventSubscriptionResource> lro = await domainTopicEventSubscription.UpdateAsync(WaitUntil.Completed, patch);
            DomainTopicEventSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopicEventSubscriptions_GetFullUrl
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFullUri_DomainTopicEventSubscriptionsGetFullUrl()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/DomainTopicEventSubscriptions_GetFullUrl.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_GetFullUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicEventSubscriptionResource created on azure
            // for more information of creating DomainTopicEventSubscriptionResource, please refer to the document of DomainTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier domainTopicEventSubscriptionResourceId = DomainTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName, eventSubscriptionName);
            DomainTopicEventSubscriptionResource domainTopicEventSubscription = client.GetDomainTopicEventSubscriptionResource(domainTopicEventSubscriptionResourceId);

            // invoke the operation
            EventSubscriptionFullUri result = await domainTopicEventSubscription.GetFullUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
