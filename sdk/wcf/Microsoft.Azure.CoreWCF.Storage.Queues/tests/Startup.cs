// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Contracts;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Azure.Storage.CoreWCF.Channels;
using QueuesClientBuilder = Azure.Storage.Test.Shared.ClientBuilder<
        Azure.Storage.Queues.QueueServiceClient,
        Azure.Storage.Queues.QueueClientOptions>;

namespace CoreWCF.AzureQueueStorage.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
            services.AddServiceModelServices();

            //add the disposable queue to DI
            services.AddSingleton(provider =>
            {
                QueueTestBase queueTestBase = new QueueTestBase(true);
                Task<DisposingQueue> task = queueTestBase.GetTestQueueAsync();
                task.Wait();
                return task.Result;
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            DisposingQueue disposingQueue = app.ApplicationServices.GetRequiredService<DisposingQueue>();
            QueuesClientBuilder clientBuilder = default;
            string accountName = clientBuilder.Tenants.TestConfigDefault.AccountName;
            string accountKey = clientBuilder.Tenants.TestConfigDefault.AccountKey;
            string connectionString = $"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey}";

            app.UseServiceModel(services =>
            {
                services.AddService<TestService>();
                services.AddServiceEndpoint<TestService, ITestContract>(new AzureQueueStorageBinding(connectionString, disposingQueue.Queue.Name),
                   AzureQueueStorageQueueNameConverter.GetEndpointUrl(disposingQueue.Queue.AccountName, disposingQueue.Queue.Name));
            });
        }
    }
}