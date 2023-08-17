// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Contracts;
using CoreWCF.Channels;
using CoreWCF.Configuration;
using CoreWCF.AzureQueueStorage.Tests.Helpers;
using CoreWCF.Queue.Common.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NUnit;
using Azure.Storage.CoreWCF.Channels;
using Azure.Storage.Queues;
using System.Collections.Generic;
using System.Web.Services.Description;
using QueuesClientBuilder = Azure.Storage.Test.Shared.ClientBuilder<
    Azure.Storage.Queues.QueueServiceClient,
    Azure.Storage.Queues.QueueClientOptions>;
using Azure.Storage.Test.Shared;
using static System.Net.WebRequestMethods;
using System.Windows.Input;

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

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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