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
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    internal partial class AssetFiltersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AssetFiltersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AssetFiltersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string accountName, string assetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Media/mediaServices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/assets/", false);
            uri.AppendPath(assetName, true);
            uri.AppendPath("/assetFilters", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List Asset Filters associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssetFilterListResult>> ListAsync(string subscriptionId, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, assetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetFilterListResult.DeserializeAssetFilterListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Asset Filters associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssetFilterListResult> List(string subscriptionId, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, assetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetFilterListResult.DeserializeAssetFilterListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Media/mediaServices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/assets/", false);
            uri.AppendPath(assetName, true);
            uri.AppendPath("/assetFilters/", false);
            uri.AppendPath(filterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the details of an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssetFilterData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssetFilterData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the details of an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssetFilterData> Get(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssetFilterData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Media/mediaServices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/assets/", false);
            uri.AppendPath(assetName, true);
            uri.AppendPath("/assetFilters/", false);
            uri.AppendPath(filterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/>, <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssetFilterData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AssetFilterData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/>, <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssetFilterData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AssetFilterData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Media/mediaServices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/assets/", false);
            uri.AppendPath(assetName, true);
            uri.AppendPath("/assetFilters/", false);
            uri.AppendPath(filterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Media/mediaServices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/assets/", false);
            uri.AppendPath(assetName, true);
            uri.AppendPath("/assetFilters/", false);
            uri.AppendPath(filterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates an existing Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/>, <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssetFilterData>> UpdateAsync(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates an existing Asset Filter associated with the specified Asset. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/>, <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="assetName"/> or <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssetFilterData> Update(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName, AssetFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, accountName, assetName, filterName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetFilterData.DeserializeAssetFilterData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string assetName)
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

        /// <summary> List Asset Filters associated with the specified Asset. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssetFilterListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, assetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetFilterListResult.DeserializeAssetFilterListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Asset Filters associated with the specified Asset. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssetFilterListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, assetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetFilterListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetFilterListResult.DeserializeAssetFilterListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
