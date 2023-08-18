// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback provider specific details. </summary>
    public partial class InMageRcmFailbackReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of InMageRcmFailbackReplicationDetails. </summary>
        internal InMageRcmFailbackReplicationDetails()
        {
            ProtectedDisks = new ChangeTrackingList<InMageRcmFailbackProtectedDiskDetails>();
            VmNics = new ChangeTrackingList<InMageRcmFailbackNicDetails>();
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of InMageRcmFailbackReplicationDetails. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="internalIdentifier"> The virtual machine internal identifier. </param>
        /// <param name="azureVirtualMachineId"> The ARM Id of the azure VM. </param>
        /// <param name="multiVmGroupName"> The multi VM group name. </param>
        /// <param name="reprotectAgentId"> The reprotect agent Id. </param>
        /// <param name="reprotectAgentName"> The reprotect agent name. </param>
        /// <param name="osType"> The type of the OS on the VM. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="targetVCenterId"> The target vCenter Id. </param>
        /// <param name="targetDataStoreName"> The target datastore name. </param>
        /// <param name="targetVmName"> The target VM name. </param>
        /// <param name="initialReplicationProgressPercentage"> The initial replication progress percentage. </param>
        /// <param name="initialReplicationProcessedBytes"> The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM. </param>
        /// <param name="initialReplicationTransferredBytes"> The initial replication transferred bytes from source VM to target for all selected disks on source VM. </param>
        /// <param name="initialReplicationProgressHealth"> The initial replication progress health. </param>
        /// <param name="resyncProgressPercentage"> The resync progress percentage. </param>
        /// <param name="resyncProcessedBytes"> The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM. </param>
        /// <param name="resyncTransferredBytes"> The resync transferred bytes from source VM to target for all selected disks on source VM. </param>
        /// <param name="resyncProgressHealth"> The resync progress health. </param>
        /// <param name="resyncRequired"> A value indicating whether resync is required. </param>
        /// <param name="resyncState"> The resync state. </param>
        /// <param name="protectedDisks"> The list of protected disks. </param>
        /// <param name="mobilityAgentDetails"> The mobility agent information. </param>
        /// <param name="vmNics"> The network details. </param>
        /// <param name="lastPlannedFailoverStartOn"> The last planned failover start time. </param>
        /// <param name="lastPlannedFailoverStatus"> The last planned failover status. </param>
        /// <param name="discoveredVmDetails"> The discovered VM information. </param>
        /// <param name="lastUsedPolicyId"> The policy Id used by the forward replication. </param>
        /// <param name="lastUsedPolicyFriendlyName"> The policy friendly name used by the forward replication. </param>
        /// <param name="isAgentRegistrationSuccessfulAfterFailover"> A value indicating whether agent registration was successful after failover. </param>
        internal InMageRcmFailbackReplicationDetails(string instanceType, string internalIdentifier, ResourceIdentifier azureVirtualMachineId, string multiVmGroupName, string reprotectAgentId, string reprotectAgentName, string osType, ResourceIdentifier logStorageAccountId, string targetVCenterId, string targetDataStoreName, string targetVmName, int? initialReplicationProgressPercentage, long? initialReplicationProcessedBytes, long? initialReplicationTransferredBytes, VmReplicationProgressHealth? initialReplicationProgressHealth, int? resyncProgressPercentage, long? resyncProcessedBytes, long? resyncTransferredBytes, VmReplicationProgressHealth? resyncProgressHealth, string resyncRequired, SiteRecoveryResyncState? resyncState, IReadOnlyList<InMageRcmFailbackProtectedDiskDetails> protectedDisks, InMageRcmFailbackMobilityAgentDetails mobilityAgentDetails, IReadOnlyList<InMageRcmFailbackNicDetails> vmNics, DateTimeOffset? lastPlannedFailoverStartOn, PlannedFailoverStatus? lastPlannedFailoverStatus, InMageRcmFailbackDiscoveredProtectedVmDetails discoveredVmDetails, ResourceIdentifier lastUsedPolicyId, string lastUsedPolicyFriendlyName, bool? isAgentRegistrationSuccessfulAfterFailover) : base(instanceType)
        {
            InternalIdentifier = internalIdentifier;
            AzureVirtualMachineId = azureVirtualMachineId;
            MultiVmGroupName = multiVmGroupName;
            ReprotectAgentId = reprotectAgentId;
            ReprotectAgentName = reprotectAgentName;
            OSType = osType;
            LogStorageAccountId = logStorageAccountId;
            TargetVCenterId = targetVCenterId;
            TargetDataStoreName = targetDataStoreName;
            TargetVmName = targetVmName;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            InitialReplicationProcessedBytes = initialReplicationProcessedBytes;
            InitialReplicationTransferredBytes = initialReplicationTransferredBytes;
            InitialReplicationProgressHealth = initialReplicationProgressHealth;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTransferredBytes = resyncTransferredBytes;
            ResyncProgressHealth = resyncProgressHealth;
            ResyncRequired = resyncRequired;
            ResyncState = resyncState;
            ProtectedDisks = protectedDisks;
            MobilityAgentDetails = mobilityAgentDetails;
            VmNics = vmNics;
            LastPlannedFailoverStartOn = lastPlannedFailoverStartOn;
            LastPlannedFailoverStatus = lastPlannedFailoverStatus;
            DiscoveredVmDetails = discoveredVmDetails;
            LastUsedPolicyId = lastUsedPolicyId;
            LastUsedPolicyFriendlyName = lastUsedPolicyFriendlyName;
            IsAgentRegistrationSuccessfulAfterFailover = isAgentRegistrationSuccessfulAfterFailover;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> The virtual machine internal identifier. </summary>
        public string InternalIdentifier { get; }
        /// <summary> The ARM Id of the azure VM. </summary>
        public ResourceIdentifier AzureVirtualMachineId { get; }
        /// <summary> The multi VM group name. </summary>
        public string MultiVmGroupName { get; }
        /// <summary> The reprotect agent Id. </summary>
        public string ReprotectAgentId { get; }
        /// <summary> The reprotect agent name. </summary>
        public string ReprotectAgentName { get; }
        /// <summary> The type of the OS on the VM. </summary>
        public string OSType { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The target vCenter Id. </summary>
        public string TargetVCenterId { get; }
        /// <summary> The target datastore name. </summary>
        public string TargetDataStoreName { get; }
        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; }
        /// <summary> The initial replication progress percentage. </summary>
        public int? InitialReplicationProgressPercentage { get; }
        /// <summary> The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM. </summary>
        public long? InitialReplicationProcessedBytes { get; }
        /// <summary> The initial replication transferred bytes from source VM to target for all selected disks on source VM. </summary>
        public long? InitialReplicationTransferredBytes { get; }
        /// <summary> The initial replication progress health. </summary>
        public VmReplicationProgressHealth? InitialReplicationProgressHealth { get; }
        /// <summary> The resync progress percentage. </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM. </summary>
        public long? ResyncProcessedBytes { get; }
        /// <summary> The resync transferred bytes from source VM to target for all selected disks on source VM. </summary>
        public long? ResyncTransferredBytes { get; }
        /// <summary> The resync progress health. </summary>
        public VmReplicationProgressHealth? ResyncProgressHealth { get; }
        /// <summary> A value indicating whether resync is required. </summary>
        public string ResyncRequired { get; }
        /// <summary> The resync state. </summary>
        public SiteRecoveryResyncState? ResyncState { get; }
        /// <summary> The list of protected disks. </summary>
        public IReadOnlyList<InMageRcmFailbackProtectedDiskDetails> ProtectedDisks { get; }
        /// <summary> The mobility agent information. </summary>
        public InMageRcmFailbackMobilityAgentDetails MobilityAgentDetails { get; }
        /// <summary> The network details. </summary>
        public IReadOnlyList<InMageRcmFailbackNicDetails> VmNics { get; }
        /// <summary> The last planned failover start time. </summary>
        public DateTimeOffset? LastPlannedFailoverStartOn { get; }
        /// <summary> The last planned failover status. </summary>
        public PlannedFailoverStatus? LastPlannedFailoverStatus { get; }
        /// <summary> The discovered VM information. </summary>
        public InMageRcmFailbackDiscoveredProtectedVmDetails DiscoveredVmDetails { get; }
        /// <summary> The policy Id used by the forward replication. </summary>
        public ResourceIdentifier LastUsedPolicyId { get; }
        /// <summary> The policy friendly name used by the forward replication. </summary>
        public string LastUsedPolicyFriendlyName { get; }
        /// <summary> A value indicating whether agent registration was successful after failover. </summary>
        public bool? IsAgentRegistrationSuccessfulAfterFailover { get; }
    }
}
