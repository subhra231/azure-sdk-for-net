// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Contracts;
using CoreWCF.AzureQueueStorage.Tests.Helpers;
using Microsoft.AspNetCore.Hosting;
using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

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
