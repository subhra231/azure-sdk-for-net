// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AdaptiveApplicationControlGroupResource" /> and their operations.
    /// Each <see cref="AdaptiveApplicationControlGroupResource" /> in the collection will belong to the same instance of <see cref="SecurityCenterLocationResource" />.
    /// To get an <see cref="AdaptiveApplicationControlGroupCollection" /> instance call the GetAdaptiveApplicationControlGroups method from an instance of <see cref="SecurityCenterLocationResource" />.
    /// </summary>
    public partial class AdaptiveApplicationControlGroupCollection : ArmCollection
    {
        private readonly ClientDiagnostics _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics;
        private readonly AdaptiveApplicationControlsRestOperations _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AdaptiveApplicationControlGroupCollection"/> class for mocking. </summary>
        protected AdaptiveApplicationControlGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AdaptiveApplicationControlGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AdaptiveApplicationControlGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", AdaptiveApplicationControlGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AdaptiveApplicationControlGroupResource.ResourceType, out string adaptiveApplicationControlGroupAdaptiveApplicationControlsApiVersion);
            _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient = new AdaptiveApplicationControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, adaptiveApplicationControlGroupAdaptiveApplicationControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityCenterLocationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityCenterLocationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="data"> The AdaptiveApplicationControlGroup to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AdaptiveApplicationControlGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string groupName, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.PutAsync(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<AdaptiveApplicationControlGroupResource>(Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="data"> The AdaptiveApplicationControlGroup to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AdaptiveApplicationControlGroupResource> CreateOrUpdate(WaitUntil waitUntil, string groupName, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Put(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<AdaptiveApplicationControlGroupResource>(Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<AdaptiveApplicationControlGroupResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<AdaptiveApplicationControlGroupResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<NullableResponse<AdaptiveApplicationControlGroupResource>> GetIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AdaptiveApplicationControlGroupResource>(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual NullableResponse<AdaptiveApplicationControlGroupResource> GetIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Name), groupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AdaptiveApplicationControlGroupResource>(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
