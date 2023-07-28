// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage;
using Azure.Storage.CoreWCF.Channels;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Contracts;
using CoreWCF.AzureQueueStorage.Tests.Helpers;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Hosting;
using Moq;
using NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using System.Threading;
using CoreWCF.Queue.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace CoreWCF.AzureQueueStorage.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        //private readonly ITestOutputHelper _output;

        [Test]
        public void ClassicQueueWithTls_SendReceiveMessage_Success()
        {
            IWebHost host = ServiceHelper.CreateWebHostBuilder<DefaultClassicQueueStartup>(_output).Build();
            using (host)
            {
                host.Start();

                var uri = ClassicQueueWithTLSStartup.Uri;
                var credentials = ClassicQueueWithTLSStartup.Credentials.GetCredential(uri, string.Empty);
                var userName = credentials.UserName;
                var password = credentials.Password;
                var sslOption = ClassicQueueWithTLSStartup.SslOption;

                // Send a message with the client
                var endpointAddress = new System.ServiceModel.EndpointAddress(uri);
                var rabbitMqBinding = new ServiceModel.Channels.RabbitMqBinding()
                {
                    SslOption = sslOption
                };
                var factory = new ChannelFactory<ITestContract>(rabbitMqBinding, endpointAddress);
                factory.Credentials.UserName.UserName = userName;
                factory.Credentials.UserName.Password = password;
                var channel = factory.CreateChannel();
                ((System.ServiceModel.Channels.IChannel)channel).Open();
                channel.Create($"IntegrationTestMessage: {nameof(ClassicQueueWithTls_SendReceiveMessage_Success)}");

                var resolver = new DependencyResolverHelper(host);
                var testService = resolver.GetService<TestService>();
                Assert.True(testService.ManualResetEvent.Wait(System.TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void MyTestMethod()
        {
            string queueName = Randomize("sample-queue");
            QueueClient queue = new QueueClient(ConnectionString, queueName);
            try
            {
                //Sample01a_HelloWorld.SendMessage(ConnectionString, queueName);

                // Verify we uploaded one message
                Assert.AreEqual(1, queue.PeekMessages().Value.Length);
            }
            finally
            {
                queue.Delete();
            }
           // string queueName = Randomize("sample-queue");
           // QueueClient queue = new QueueClient(ConnectionString, queueName);
            try
            {
              //  Sample01a_HelloWorld.SendMessage(ConnectionString, queueName);

                // Verify we uploaded one message
                Assert.AreEqual(1, queue.PeekMessages().Value.Length);
            }
            finally
            {
                queue.Delete();
            }
        }





        [Test]
        public async Task ReceiveQueueMessageContextAsync_MessageAvailable_ReturnsQueueMessageContext()
        {
            // Arrange
            var cancellationToken = CancellationToken.None;
            string queueName = Randomize("sample-queue");
            QueueClient queue = new QueueClient(ConnectionString, queueName);
            try
            {
                queue.SendMessage("Test message");

                // Verify we uploaded one message
                Assert.AreEqual(1, queue.PeekMessages().Value.Length);


                // get queue from DI

                IWebHost host = ServiceHelper.CreateWebHostBuilder<Startup>(_output).Build();
                using (host)
                {
                    host.Start();


                }

                    var baseAddress = new Uri("http://localhost");
                var azureQueueStorageTransportBindingElement = new AzureQueueStorageTransportBindingElement();
                QueueTransportPump queueTransportPump = azureQueueStorageTransportBindingElement.BuildQueueTransportPump(context);

                var transport = new AzureQueueStorageQueueTransport(serviceDispatcher.Object, serviceProvider.Object, azureQueueStorageTransportBindingElement);

                // Act
                var result = await transport.ReceiveQueueMessageContextAsync(cancellationToken);

                // Assert
                Assert.IsNotNull(result);


            }
            finally
            {
                await queue.DeleteAsync();
            }

        }


        /*private readonly ITestOutputHelper _output = null;
        public const string QueueName = "AzureQueue";

        [Fact(Skip = "Need AzureQueue")]
        public void ReceiveMessage_ServiceCall_Success()
        {
            IWebHost host = ServiceHelper.CreateWebHostBuilder<Startup>(_output).Build();
            using (host)
            {
                host.Start();
                QueueClient queue = new QueueClient(connectionString, queueName);
                queue.Create();
                QueueServiceClient serviceClient = InstrumentClient(new QueueServiceClient(
                connectionString));
                QueueClient queueClient = serviceClient.GetQueueClient(GetNewQueueName());
                MessageQueueHelper.SendMessageInQueue(QueueName);

                var resolver = new DependencyResolverHelper(host);
                var testService = resolver.GetService<TestService>();
                Assert.True(testService.ManualResetEvent.Wait(System.TimeSpan.FromSeconds(5)));
            }
        }*/
    }
}
