// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkGroup data model.
    /// The network group resource
    /// </summary>
    public partial class NetworkGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkGroupData. </summary>
        public NetworkGroupData()
        {
        }

        /// <summary> Initializes a new instance of NetworkGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description of the network group. </param>
        /// <param name="provisioningState"> The provisioning state of the scope assignment resource. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal NetworkGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, NetworkProvisioningState? provisioningState, Guid? resourceGuid, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            ETag = etag;
        }

        /// <summary> A description of the network group. </summary>
        public string Description { get; set; }
        /// <summary> The provisioning state of the scope assignment resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
