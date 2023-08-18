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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServerAadAdministratorResource" /> and their operations.
    /// Each <see cref="MySqlFlexibleServerAadAdministratorResource" /> in the collection will belong to the same instance of <see cref="MySqlFlexibleServerResource" />.
    /// To get a <see cref="MySqlFlexibleServerAadAdministratorCollection" /> instance call the GetMySqlFlexibleServerAadAdministrators method from an instance of <see cref="MySqlFlexibleServerResource" />.
    /// </summary>
    public partial class MySqlFlexibleServerAadAdministratorCollection : ArmCollection, IEnumerable<MySqlFlexibleServerAadAdministratorResource>, IAsyncEnumerable<MySqlFlexibleServerAadAdministratorResource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics;
        private readonly AzureADAdministratorsRestOperations _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerAadAdministratorCollection"/> class for mocking. </summary>
        protected MySqlFlexibleServerAadAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerAadAdministratorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlFlexibleServerAadAdministratorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerAadAdministratorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerAadAdministratorResource.ResourceType, out string mySqlFlexibleServerAadAdministratorAzureADAdministratorsApiVersion);
            _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient = new AzureADAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerAadAdministratorAzureADAdministratorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="data"> The required parameters for creating or updating an aad administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlFlexibleServerAadAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, MySqlFlexibleServerAdministratorName administratorName, MySqlFlexibleServerAadAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerAadAdministratorResource>(new MySqlFlexibleServerAadAdministratorOperationSource(Client), _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics, Pipeline, _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="data"> The required parameters for creating or updating an aad administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlFlexibleServerAadAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, MySqlFlexibleServerAdministratorName administratorName, MySqlFlexibleServerAadAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerAadAdministratorResource>(new MySqlFlexibleServerAadAdministratorOperationSource(Client), _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics, Pipeline, _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about an azure ad administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerAadAdministratorResource>> GetAsync(MySqlFlexibleServerAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerAadAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about an azure ad administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerAadAdministratorResource> Get(MySqlFlexibleServerAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerAadAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the AAD administrators in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerAadAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerAadAdministratorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerAadAdministratorResource(Client, MySqlFlexibleServerAadAdministratorData.DeserializeMySqlFlexibleServerAadAdministratorData(e)), _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics, Pipeline, "MySqlFlexibleServerAadAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the AAD administrators in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerAadAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerAadAdministratorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerAadAdministratorResource(Client, MySqlFlexibleServerAadAdministratorData.DeserializeMySqlFlexibleServerAadAdministratorData(e)), _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics, Pipeline, "MySqlFlexibleServerAadAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(MySqlFlexibleServerAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of the Azure AD Administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(MySqlFlexibleServerAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsClientDiagnostics.CreateScope("MySqlFlexibleServerAadAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerAadAdministratorAzureADAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServerAadAdministratorResource> IEnumerable<MySqlFlexibleServerAadAdministratorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServerAadAdministratorResource> IAsyncEnumerable<MySqlFlexibleServerAadAdministratorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
