// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Capability for the PostgreSQL server. </summary>
    public partial class PostgreSqlFlexibleServerCapabilityProperties : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerCapabilityProperties. </summary>
        internal PostgreSqlFlexibleServerCapabilityProperties()
        {
            SupportedServerEditions = new ChangeTrackingList<PostgreSqlFlexibleServerEditionCapability>();
            SupportedServerVersions = new ChangeTrackingList<PostgreSqlFlexibleServerServerVersionCapability>();
            SupportedFastProvisioningEditions = new ChangeTrackingList<PostgreSqlFlexibleServerFastProvisioningEditionCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerCapabilityProperties. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="name"> Name of flexible servers capability. </param>
        /// <param name="supportedServerEditions"> List of supported flexible server editions. </param>
        /// <param name="supportedServerVersions"> The list of server versions supported for this capability. </param>
        /// <param name="supportFastProvisioning"> Gets a value indicating whether fast provisioning is supported. "Enabled" means fast provisioning is supported. "Disabled" stands for fast provisioning is not supported. </param>
        /// <param name="supportedFastProvisioningEditions"> List of supported server editions for fast provisioning. </param>
        /// <param name="geoBackupSupported"> Determines if geo-backup is supported in this region. "Enabled" means geo-backup is supported. "Disabled" stands for geo-back is not supported. </param>
        /// <param name="zoneRedundantHaSupported"> A value indicating whether Zone Redundant HA is supported in this region. "Enabled" means zone redundant HA is supported. "Disabled" stands for zone redundant HA is not supported. </param>
        /// <param name="zoneRedundantHaAndGeoBackupSupported"> A value indicating whether Zone Redundant HA and Geo-backup is supported in this region. "Enabled" means zone redundant HA and geo-backup is supported. "Disabled" stands for zone redundant HA and geo-backup is not supported. </param>
        /// <param name="storageAutoGrowthSupported"> A value indicating whether storage auto-grow is supported in this region. "Enabled" means storage auto-grow is supported. "Disabled" stands for storage auto-grow is not supported. </param>
        /// <param name="onlineResizeSupported"> A value indicating whether online resize is supported in this region for the given subscription. "Enabled" means storage online resize is supported. "Disabled" means storage online resize is not supported. </param>
        /// <param name="restricted"> A value indicating whether this region is restricted. "Enabled" means region is restricted. "Disabled" stands for region is not restricted. </param>
        internal PostgreSqlFlexibleServerCapabilityProperties(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, string name, IReadOnlyList<PostgreSqlFlexibleServerEditionCapability> supportedServerEditions, IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability> supportedServerVersions, PostgreSqlFlexibleServerFastProvisioningSupported? supportFastProvisioning, IReadOnlyList<PostgreSqlFlexibleServerFastProvisioningEditionCapability> supportedFastProvisioningEditions, PostgreSqlFlexibleServerGeoBackupSupported? geoBackupSupported, PostgreSqlFlexibleServerZoneRedundantHaSupported? zoneRedundantHaSupported, PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported? zoneRedundantHaAndGeoBackupSupported, PostgreSqlFlexibleServerStorageAutoGrowthSupported? storageAutoGrowthSupported, PostgreSqlFlexibleServerOnlineResizeSupported? onlineResizeSupported, PostgreSqlFlexibleServerZoneRedundantRestricted? restricted) : base(capabilityStatus, reason)
        {
            Name = name;
            SupportedServerEditions = supportedServerEditions;
            SupportedServerVersions = supportedServerVersions;
            SupportFastProvisioning = supportFastProvisioning;
            SupportedFastProvisioningEditions = supportedFastProvisioningEditions;
            GeoBackupSupported = geoBackupSupported;
            ZoneRedundantHaSupported = zoneRedundantHaSupported;
            ZoneRedundantHaAndGeoBackupSupported = zoneRedundantHaAndGeoBackupSupported;
            StorageAutoGrowthSupported = storageAutoGrowthSupported;
            OnlineResizeSupported = onlineResizeSupported;
            Restricted = restricted;
        }

        /// <summary> Name of flexible servers capability. </summary>
        public string Name { get; }
        /// <summary> List of supported flexible server editions. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerEditionCapability> SupportedServerEditions { get; }
        /// <summary> The list of server versions supported for this capability. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability> SupportedServerVersions { get; }
        /// <summary> Gets a value indicating whether fast provisioning is supported. "Enabled" means fast provisioning is supported. "Disabled" stands for fast provisioning is not supported. </summary>
        public PostgreSqlFlexibleServerFastProvisioningSupported? SupportFastProvisioning { get; }
        /// <summary> List of supported server editions for fast provisioning. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerFastProvisioningEditionCapability> SupportedFastProvisioningEditions { get; }
        /// <summary> Determines if geo-backup is supported in this region. "Enabled" means geo-backup is supported. "Disabled" stands for geo-back is not supported. </summary>
        public PostgreSqlFlexibleServerGeoBackupSupported? GeoBackupSupported { get; }
        /// <summary> A value indicating whether Zone Redundant HA is supported in this region. "Enabled" means zone redundant HA is supported. "Disabled" stands for zone redundant HA is not supported. </summary>
        public PostgreSqlFlexibleServerZoneRedundantHaSupported? ZoneRedundantHaSupported { get; }
        /// <summary> A value indicating whether Zone Redundant HA and Geo-backup is supported in this region. "Enabled" means zone redundant HA and geo-backup is supported. "Disabled" stands for zone redundant HA and geo-backup is not supported. </summary>
        public PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported? ZoneRedundantHaAndGeoBackupSupported { get; }
        /// <summary> A value indicating whether storage auto-grow is supported in this region. "Enabled" means storage auto-grow is supported. "Disabled" stands for storage auto-grow is not supported. </summary>
        public PostgreSqlFlexibleServerStorageAutoGrowthSupported? StorageAutoGrowthSupported { get; }
        /// <summary> A value indicating whether online resize is supported in this region for the given subscription. "Enabled" means storage online resize is supported. "Disabled" means storage online resize is not supported. </summary>
        public PostgreSqlFlexibleServerOnlineResizeSupported? OnlineResizeSupported { get; }
        /// <summary> A value indicating whether this region is restricted. "Enabled" means region is restricted. "Disabled" stands for region is not restricted. </summary>
        public PostgreSqlFlexibleServerZoneRedundantRestricted? Restricted { get; }
    }
}
