// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.CoreWCF.Channels;
using Azure.Storage.Queues;
using Contracts;
using CoreWCF.Configuration;
using CoreWCF.Queue.Common.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreWCF.AzureQueueStorage.Tests
{
    public class Startup
    {
        private readonly string queueName = "queue-name";
        private string connectionString = null;
        private string endpointUrlString = null;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
            services.AddServiceModelServices();
            services.AddQueueTransport();
            var azuriteFixture = AzuriteNUnitFixture.Instance;
            var transport = azuriteFixture.GetTransport();
            connectionString = azuriteFixture.GetAzureAccount().ConnectionString;
            var endpointUriBuilder = new UriBuilder(azuriteFixture.GetAzureAccount().QueueEndpoint + "/" + queueName);
            endpointUriBuilder.Scheme = "net.aqs";
            endpointUrlString = endpointUriBuilder.Uri.AbsoluteUri;
            var queueClient = new QueueClient(connectionString, queueName, new QueueClientOptions { Transport = transport });
            queueClient.CreateIfNotExists();
            services.AddSingleton(queueClient);
        }

        public void Configure(IApplicationBuilder app)
        {
            QueueClient queue = app.ApplicationServices.GetRequiredService<QueueClient>();

            app.UseServiceModel(services =>
            {
                services.AddService<TestService>();
                services.AddServiceEndpoint<TestService, ITestContract>(new AzureQueueStorageBinding(connectionString, queueName),
                   endpointUrlString);
            });
        }
    }
}