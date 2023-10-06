// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    internal partial class DiscoverySolutionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DiscoverySolutionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DiscoverySolutionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string scope, string filter, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/discoverySolutions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, false);
            }
            if (skiptoken != null)
            {
                uri.AppendQuery("$skiptoken", skiptoken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<SelfHelpDiscoverySolutionResult>> ListAsync(string scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope, filter, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiscoverySolutionResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SelfHelpDiscoverySolutionResult.DeserializeSelfHelpDiscoverySolutionResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<SelfHelpDiscoverySolutionResult> List(string scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope, filter, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiscoverySolutionResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SelfHelpDiscoverySolutionResult.DeserializeSelfHelpDiscoverySolutionResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope, string filter, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<SelfHelpDiscoverySolutionResult>> ListNextPageAsync(string nextLink, string scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope, filter, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiscoverySolutionResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SelfHelpDiscoverySolutionResult.DeserializeSelfHelpDiscoverySolutionResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<SelfHelpDiscoverySolutionResult> ListNextPage(string nextLink, string scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope, filter, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiscoverySolutionResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SelfHelpDiscoverySolutionResult.DeserializeSelfHelpDiscoverySolutionResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
