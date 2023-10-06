// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary>
    /// A class representing a collection of <see cref="MaintenancePublicConfigurationResource" /> and their operations.
    /// Each <see cref="MaintenancePublicConfigurationResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="MaintenancePublicConfigurationCollection" /> instance call the GetMaintenancePublicConfigurations method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class MaintenancePublicConfigurationCollection : ArmCollection, IEnumerable<MaintenancePublicConfigurationResource>, IAsyncEnumerable<MaintenancePublicConfigurationResource>
    {
        private readonly ClientDiagnostics _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics;
        private readonly PublicMaintenanceConfigurationsRestOperations _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MaintenancePublicConfigurationCollection"/> class for mocking. </summary>
        protected MaintenancePublicConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenancePublicConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MaintenancePublicConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maintenance", MaintenancePublicConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MaintenancePublicConfigurationResource.ResourceType, out string maintenancePublicConfigurationPublicMaintenanceConfigurationsApiVersion);
            _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient = new PublicMaintenanceConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, maintenancePublicConfigurationPublicMaintenanceConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Public Maintenance Configuration record
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<MaintenancePublicConfigurationResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.GetAsync(Id.SubscriptionId, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenancePublicConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Public Maintenance Configuration record
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<MaintenancePublicConfigurationResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.Get(Id.SubscriptionId, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenancePublicConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Public Maintenance Configuration records
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MaintenancePublicConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MaintenancePublicConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MaintenancePublicConfigurationResource(Client, MaintenanceConfigurationData.DeserializeMaintenanceConfigurationData(e)), _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics, Pipeline, "MaintenancePublicConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get Public Maintenance Configuration records
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MaintenancePublicConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MaintenancePublicConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MaintenancePublicConfigurationResource(Client, MaintenanceConfigurationData.DeserializeMaintenanceConfigurationData(e)), _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics, Pipeline, "MaintenancePublicConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.GetAsync(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.Get(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MaintenancePublicConfigurationResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.GetAsync(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MaintenancePublicConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MaintenancePublicConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicMaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<MaintenancePublicConfigurationResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _maintenancePublicConfigurationPublicMaintenanceConfigurationsClientDiagnostics.CreateScope("MaintenancePublicConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _maintenancePublicConfigurationPublicMaintenanceConfigurationsRestClient.Get(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MaintenancePublicConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MaintenancePublicConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MaintenancePublicConfigurationResource> IEnumerable<MaintenancePublicConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MaintenancePublicConfigurationResource> IAsyncEnumerable<MaintenancePublicConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
