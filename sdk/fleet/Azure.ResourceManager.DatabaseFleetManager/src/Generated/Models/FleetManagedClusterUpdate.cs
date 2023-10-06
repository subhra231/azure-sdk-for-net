// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> The update to be applied to the ManagedClusters. </summary>
    public partial class FleetManagedClusterUpdate
    {
        /// <summary> Initializes a new instance of FleetManagedClusterUpdate. </summary>
        /// <param name="upgrade"> The upgrade to apply to the ManagedClusters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="upgrade"/> is null. </exception>
        public FleetManagedClusterUpdate(FleetManagedClusterUpgradeSpec upgrade)
        {
            Argument.AssertNotNull(upgrade, nameof(upgrade));

            Upgrade = upgrade;
        }

        /// <summary> Initializes a new instance of FleetManagedClusterUpdate. </summary>
        /// <param name="upgrade"> The upgrade to apply to the ManagedClusters. </param>
        /// <param name="nodeImageSelection"> The node image upgrade to be applied to the target nodes in update run. </param>
        internal FleetManagedClusterUpdate(FleetManagedClusterUpgradeSpec upgrade, NodeImageSelection nodeImageSelection)
        {
            Upgrade = upgrade;
            NodeImageSelection = nodeImageSelection;
        }

        /// <summary> The upgrade to apply to the ManagedClusters. </summary>
        public FleetManagedClusterUpgradeSpec Upgrade { get; set; }
        /// <summary> The node image upgrade to be applied to the target nodes in update run. </summary>
        internal NodeImageSelection NodeImageSelection { get; set; }
        /// <summary> The node image upgrade type. </summary>
        public NodeImageSelectionType? SelectionType
        {
            get => NodeImageSelection is null ? default(NodeImageSelectionType?) : NodeImageSelection.SelectionType;
            set
            {
                NodeImageSelection = value.HasValue ? new NodeImageSelection(value.Value) : null;
            }
        }
    }
}
