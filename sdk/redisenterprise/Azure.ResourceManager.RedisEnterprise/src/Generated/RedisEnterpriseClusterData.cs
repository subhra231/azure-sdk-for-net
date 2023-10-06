// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary>
    /// A class representing the RedisEnterpriseCluster data model.
    /// Describes the RedisEnterprise cluster
    /// </summary>
    public partial class RedisEnterpriseClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RedisEnterpriseClusterData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU to create, which affects price, performance, and features. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public RedisEnterpriseClusterData(AzureLocation location, RedisEnterpriseSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            Zones = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<RedisEnterprisePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of RedisEnterpriseClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU to create, which affects price, performance, and features. </param>
        /// <param name="zones"> The Availability Zones where this cluster will be deployed. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="minimumTlsVersion"> The minimum TLS version for the cluster to support, e.g. '1.2'. </param>
        /// <param name="encryption"> Encryption-at-rest configuration for the cluster. </param>
        /// <param name="hostName"> DNS name of the cluster endpoint. </param>
        /// <param name="provisioningState"> Current provisioning status of the cluster. </param>
        /// <param name="resourceState"> Current resource status of the cluster. </param>
        /// <param name="redisVersion"> Version of redis the cluster supports, e.g. '6'. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the specified RedisEnterprise cluster. </param>
        internal RedisEnterpriseClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RedisEnterpriseSku sku, IList<string> zones, ManagedServiceIdentity identity, RedisEnterpriseTlsVersion? minimumTlsVersion, ClusterPropertiesEncryption encryption, string hostName, RedisEnterpriseProvisioningStatus? provisioningState, RedisEnterpriseClusterResourceState? resourceState, string redisVersion, IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Zones = zones;
            Identity = identity;
            MinimumTlsVersion = minimumTlsVersion;
            Encryption = encryption;
            HostName = hostName;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            RedisVersion = redisVersion;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The SKU to create, which affects price, performance, and features. </summary>
        public RedisEnterpriseSku Sku { get; set; }
        /// <summary> The Availability Zones where this cluster will be deployed. </summary>
        public IList<string> Zones { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The minimum TLS version for the cluster to support, e.g. '1.2'. </summary>
        public RedisEnterpriseTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Encryption-at-rest configuration for the cluster. </summary>
        internal ClusterPropertiesEncryption Encryption { get; set; }
        /// <summary> All Customer-managed key encryption properties for the resource. Set this to an empty object to use Microsoft-managed key encryption. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryption CustomerManagedKeyEncryption
        {
            get => Encryption is null ? default : Encryption.CustomerManagedKeyEncryption;
            set
            {
                if (Encryption is null)
                    Encryption = new ClusterPropertiesEncryption();
                Encryption.CustomerManagedKeyEncryption = value;
            }
        }

        /// <summary> DNS name of the cluster endpoint. </summary>
        public string HostName { get; }
        /// <summary> Current provisioning status of the cluster. </summary>
        public RedisEnterpriseProvisioningStatus? ProvisioningState { get; }
        /// <summary> Current resource status of the cluster. </summary>
        public RedisEnterpriseClusterResourceState? ResourceState { get; }
        /// <summary> Version of redis the cluster supports, e.g. '6'. </summary>
        public string RedisVersion { get; }
        /// <summary> List of private endpoint connections associated with the specified RedisEnterprise cluster. </summary>
        public IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
