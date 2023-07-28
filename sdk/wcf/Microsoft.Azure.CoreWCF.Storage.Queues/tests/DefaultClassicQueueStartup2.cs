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

    public class DefaultClassicQueueStartup2
    {
        public static Uri Uri = new("net.amqp://localhost:5672/amq.direct/corewcf-test-default-classic-queue#corewcf-test-default-classic-key");
        public static readonly ICredentials Credentials = new NetworkCredential(ConnectionFactory.DefaultUser, ConnectionFactory.DefaultPass);

        public static RabbitMqConnectionSettings ConnectionSettings => RabbitMqConnectionSettings.FromUri(Uri, Credentials);

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
            services.AddServiceModelServices();
            services.AddQueueTransport();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseServiceModel(services =>
            {
                services.AddService<TestService>();
                services.AddServiceEndpoint<TestService, ITestContract>(
                    new RabbitMqBinding
                    {
                        Credentials = Credentials,
                        QueueConfiguration = new QuorumQueueConfiguration()
                    },
                    Uri);
            });
        }
    }
}
