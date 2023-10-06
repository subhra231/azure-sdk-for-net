// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_SolutionInference
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Cancel_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Response response = client.Cancel("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Cancel_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Response response = await client.CancelAsync("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Cancel_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Response response = client.Cancel("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Cancel_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CancelAsync("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Fetch_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Response response = client.Fetch("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Fetch_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Response response = await client.FetchAsync("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Fetch_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Response response = client.Fetch("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Fetch_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Response response = await client.FetchAsync("<solutionId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Operation<BinaryData> operation = client.CreateOrUpdate(WaitUntil.Completed, "<solutionId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
            });
            Operation<BinaryData> operation = await client.CreateOrUpdateAsync(WaitUntil.Completed, "<solutionId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Operation<BinaryData> operation = client.CreateOrUpdate(WaitUntil.Completed, "<solutionId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SolutionInference client = new FarmBeatsClient(credential).GetSolutionInferenceClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                requestPath = "<requestPath>",
                partnerRequestBody = new
                {
                    key = new object(),
                },
            });
            Operation<BinaryData> operation = await client.CreateOrUpdateAsync(WaitUntil.Completed, "<solutionId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }
    }
}
