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

namespace CoreWCF.AzureQueueStorage.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
            services.AddServiceModelServices();
            //services.AddQueueTransport(x => { x.ConcurrencyLevel = 1; });
            // get connection string from settings and add queue client

            //add the disposable queue to DI
            services.AddSingleton(provider =>
            {
                QueueTestBase queueTestBase = new QueueTestBase(true);
                Task<DisposingQueue> task = queueTestBase.GetTestQueueAsync();
                task.Wait();
                return task.Result;
            });
            /*QueueTestBase queueTestBase = new QueueTestBase(true);
            Task<DisposingQueue> task = queueTestBase.GetTestQueueAsync();
            task.Wait();
            DisposingQueue result = task.Result;
            services.AddSingleton<DisposingQueue>();*/
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseServiceModel(services =>
            {
                services.AddService<TestService>();
                services.AddServiceEndpoint<TestService, ITestContract>(new AzureQueueStorageBinding(),
                    $"net.aqs://localhost/private/");
                //pull queue info like connc string and queue name
            });
        }
}


// make sure queue is disposed at the end,. else use a try catch finally to disopse

