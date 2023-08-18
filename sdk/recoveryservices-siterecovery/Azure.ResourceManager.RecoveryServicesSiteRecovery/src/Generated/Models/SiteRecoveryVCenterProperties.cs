// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> vCenter properties. </summary>
    public partial class SiteRecoveryVCenterProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryVCenterProperties. </summary>
        internal SiteRecoveryVCenterProperties()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of SiteRecoveryVCenterProperties. </summary>
        /// <param name="friendlyName"> Friendly name of the vCenter. </param>
        /// <param name="internalId"> VCenter internal ID. </param>
        /// <param name="lastHeartbeatReceivedOn"> The time when the last heartbeat was received by vCenter. </param>
        /// <param name="discoveryStatus"> The VCenter discovery status. </param>
        /// <param name="processServerId"> The process server Id. </param>
        /// <param name="ipAddress"> The IP address of the vCenter. </param>
        /// <param name="infrastructureId"> The infrastructure Id of vCenter. </param>
        /// <param name="port"> The port number for discovery. </param>
        /// <param name="runAsAccountId"> The account Id which has privileges to discover the vCenter. </param>
        /// <param name="fabricArmResourceName"> The ARM resource name of the fabric containing this VCenter. </param>
        /// <param name="healthErrors"> The health errors for this VCenter. </param>
        internal SiteRecoveryVCenterProperties(string friendlyName, string internalId, DateTimeOffset? lastHeartbeatReceivedOn, string discoveryStatus, Guid? processServerId, IPAddress ipAddress, string infrastructureId, string port, string runAsAccountId, string fabricArmResourceName, IReadOnlyList<SiteRecoveryHealthError> healthErrors)
        {
            FriendlyName = friendlyName;
            InternalId = internalId;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            DiscoveryStatus = discoveryStatus;
            ProcessServerId = processServerId;
            IPAddress = ipAddress;
            InfrastructureId = infrastructureId;
            Port = port;
            RunAsAccountId = runAsAccountId;
            FabricArmResourceName = fabricArmResourceName;
            HealthErrors = healthErrors;
        }

        /// <summary> Friendly name of the vCenter. </summary>
        public string FriendlyName { get; }
        /// <summary> VCenter internal ID. </summary>
        public string InternalId { get; }
        /// <summary> The time when the last heartbeat was received by vCenter. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The VCenter discovery status. </summary>
        public string DiscoveryStatus { get; }
        /// <summary> The process server Id. </summary>
        public Guid? ProcessServerId { get; }
        /// <summary> The IP address of the vCenter. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The infrastructure Id of vCenter. </summary>
        public string InfrastructureId { get; }
        /// <summary> The port number for discovery. </summary>
        public string Port { get; }
        /// <summary> The account Id which has privileges to discover the vCenter. </summary>
        public string RunAsAccountId { get; }
        /// <summary> The ARM resource name of the fabric containing this VCenter. </summary>
        public string FabricArmResourceName { get; }
        /// <summary> The health errors for this VCenter. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
    }
}
