// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.SqlVirtualMachine;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine.Samples
{
    public partial class Sample_AvailabilityGroupListenerCollection
    {
        // Gets an availability group listener.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAnAvailabilityGroupListener()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation
            string availabilityGroupListenerName = "agl-test";
            AvailabilityGroupListenerResource result = await collection.GetAsync(availabilityGroupListenerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets an availability group listener.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAnAvailabilityGroupListener()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation
            string availabilityGroupListenerName = "agl-test";
            bool result = await collection.ExistsAsync(availabilityGroupListenerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets an availability group listener.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsAnAvailabilityGroupListener()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation
            string availabilityGroupListenerName = "agl-test";
            NullableResponse<AvailabilityGroupListenerResource> response = await collection.GetIfExistsAsync(availabilityGroupListenerName);
            AvailabilityGroupListenerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvailabilityGroupListenerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Creates or updates an availability group listener using load balancer. This is used for VMs present in single subnet.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAnAvailabilityGroupListenerUsingLoadBalancerThisIsUsedForVMsPresentInSingleSubnet()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation
            string availabilityGroupListenerName = "agl-test";
            AvailabilityGroupListenerData data = new AvailabilityGroupListenerData()
            {
                AvailabilityGroupName = "ag-test",
                LoadBalancerConfigurations =
{
new AvailabilityGroupListenerLoadBalancerConfiguration()
{
PrivateIPAddress = new AvailabilityGroupListenerPrivateIPAddress()
{
IPAddress = IPAddress.Parse("10.1.0.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/default"),
},
LoadBalancerResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/loadBalancers/lb-test"),
ProbePort = 59983,
SqlVmInstances =
{
new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm2"),new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm3")
},
}
},
                Port = 1433,
            };
            ArmOperation<AvailabilityGroupListenerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, availabilityGroupListenerName, data);
            AvailabilityGroupListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates or updates an availability group listener. This is used for VMs present in multi subnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAnAvailabilityGroupListenerThisIsUsedForVMsPresentInMultiSubnet()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateAvailabilityGroupListenerWithMultiSubnet.json
            // this example is just showing the usage of "AvailabilityGroupListeners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation
            string availabilityGroupListenerName = "agl-test";
            AvailabilityGroupListenerData data = new AvailabilityGroupListenerData()
            {
                AvailabilityGroupName = "ag-test",
                MultiSubnetIPConfigurations =
{
new MultiSubnetIPConfiguration(new AvailabilityGroupListenerPrivateIPAddress()
{
IPAddress = IPAddress.Parse("10.0.0.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/default"),
},"/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm2"),new MultiSubnetIPConfiguration(new AvailabilityGroupListenerPrivateIPAddress()
{
IPAddress = IPAddress.Parse("10.0.1.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/alternate"),
},"/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm1")
},
                Port = 1433,
            };
            ArmOperation<AvailabilityGroupListenerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, availabilityGroupListenerName, data);
            AvailabilityGroupListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Lists all availability group listeners in a SQL virtual machine group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsAllAvailabilityGroupListenersInASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/ListByGroupAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_ListByGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // get the collection of this AvailabilityGroupListenerResource
            AvailabilityGroupListenerCollection collection = sqlVmGroup.GetAvailabilityGroupListeners();

            // invoke the operation and iterate over the result
            await foreach (AvailabilityGroupListenerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvailabilityGroupListenerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
