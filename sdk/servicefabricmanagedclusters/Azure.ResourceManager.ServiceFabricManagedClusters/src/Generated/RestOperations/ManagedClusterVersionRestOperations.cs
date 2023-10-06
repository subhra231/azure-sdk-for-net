// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal partial class ManagedClusterVersionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ManagedClusterVersionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedClusterVersionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation location, string clusterVersion)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/managedClusterVersions/", false);
            uri.AppendPath(clusterVersion, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about an available Service Fabric managed cluster code version. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricManagedClusterVersion>> GetAsync(string subscriptionId, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var message = CreateGetRequest(subscriptionId, location, clusterVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricManagedClusterVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about an available Service Fabric managed cluster code version. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricManagedClusterVersion> Get(string subscriptionId, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var message = CreateGetRequest(subscriptionId, location, clusterVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricManagedClusterVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByEnvironmentRequest(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/environments/", false);
            uri.AppendPath(environment.ToString(), true);
            uri.AppendPath("/managedClusterVersions/", false);
            uri.AppendPath(clusterVersion, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about an available Service Fabric cluster code version by environment. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricManagedClusterVersion>> GetByEnvironmentAsync(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var message = CreateGetByEnvironmentRequest(subscriptionId, location, environment, clusterVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricManagedClusterVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about an available Service Fabric cluster code version by environment. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricManagedClusterVersion> GetByEnvironment(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var message = CreateGetByEnvironmentRequest(subscriptionId, location, environment, clusterVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricManagedClusterVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, AzureLocation location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/managedClusterVersions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all available code versions for Service Fabric cluster resources by location. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<ServiceFabricManagedClusterVersion>>> ListAsync(string subscriptionId, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ServiceFabricManagedClusterVersion> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ServiceFabricManagedClusterVersion> array = new List<ServiceFabricManagedClusterVersion>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all available code versions for Service Fabric cluster resources by location. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<ServiceFabricManagedClusterVersion>> List(string subscriptionId, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ServiceFabricManagedClusterVersion> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ServiceFabricManagedClusterVersion> array = new List<ServiceFabricManagedClusterVersion>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByEnvironmentRequest(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/environments/", false);
            uri.AppendPath(environment.ToString(), true);
            uri.AppendPath("/managedClusterVersions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all available code versions for Service Fabric cluster resources by environment. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<ServiceFabricManagedClusterVersion>>> ListByEnvironmentAsync(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListByEnvironmentRequest(subscriptionId, location, environment);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ServiceFabricManagedClusterVersion> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ServiceFabricManagedClusterVersion> array = new List<ServiceFabricManagedClusterVersion>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all available code versions for Service Fabric cluster resources by environment. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<ServiceFabricManagedClusterVersion>> ListByEnvironment(string subscriptionId, AzureLocation location, ManagedClusterVersionEnvironment environment, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListByEnvironmentRequest(subscriptionId, location, environment);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ServiceFabricManagedClusterVersion> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ServiceFabricManagedClusterVersion> array = new List<ServiceFabricManagedClusterVersion>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
