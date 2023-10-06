// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Node resource group lockdown profile for a managed cluster. </summary>
    internal partial class ManagedClusterNodeResourceGroupProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterNodeResourceGroupProfile. </summary>
        public ManagedClusterNodeResourceGroupProfile()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterNodeResourceGroupProfile. </summary>
        /// <param name="restrictionLevel"> The restriction level applied to the cluster's node resource group. </param>
        internal ManagedClusterNodeResourceGroupProfile(ManagedClusterNodeResourceGroupRestrictionLevel? restrictionLevel)
        {
            RestrictionLevel = restrictionLevel;
        }

        /// <summary> The restriction level applied to the cluster's node resource group. </summary>
        public ManagedClusterNodeResourceGroupRestrictionLevel? RestrictionLevel { get; set; }
    }
}
