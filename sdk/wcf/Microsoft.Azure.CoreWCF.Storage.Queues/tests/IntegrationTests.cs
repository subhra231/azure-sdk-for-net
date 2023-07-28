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
using System.Net.Http;
using System.Web.Services.Description;

namespace CoreWCF.AzureQueueStorage.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        private IWebHost host;
        private HttpClient httpClient;

        [SetUp]
        public void Setup()
        {
            host = ServiceHelper.CreateWebHostBuilder<Startup>().Build();
            host.Start();
            httpClient = new HttpClient();
        }

        [TearDown]
        public void TearDown()
        {
            httpClient.Dispose();
            host.StopAsync().Wait();
            host.Dispose();
        }

        [Test]
        public async Task DefaultQueueConfiguration_ReceiveMessage_Success()
        {
            var queue = host.Services.GetRequiredService<DisposingQueue>();
            await queue.Queue.SendMessageAsync("");

            var testService = host.Services.GetRequiredService<TestService>();
            Assert.True(testService.ManualResetEvent.Wait(System.TimeSpan.FromSeconds(5)));
        }
    }
}
