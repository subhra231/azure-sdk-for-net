// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Backup properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerBackupProperties
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerBackupProperties. </summary>
        public PostgreSqlFlexibleServerBackupProperties()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerBackupProperties. </summary>
        /// <param name="backupRetentionDays"> Backup retention days for the server. </param>
        /// <param name="geoRedundantBackup"> A value indicating whether Geo-Redundant backup is enabled on the server. </param>
        /// <param name="earliestRestoreOn"> The earliest restore point time (ISO8601 format) for server. </param>
        internal PostgreSqlFlexibleServerBackupProperties(int? backupRetentionDays, PostgreSqlFlexibleServerGeoRedundantBackupEnum? geoRedundantBackup, DateTimeOffset? earliestRestoreOn)
        {
            BackupRetentionDays = backupRetentionDays;
            GeoRedundantBackup = geoRedundantBackup;
            EarliestRestoreOn = earliestRestoreOn;
        }

        /// <summary> Backup retention days for the server. </summary>
        public int? BackupRetentionDays { get; set; }
        /// <summary> A value indicating whether Geo-Redundant backup is enabled on the server. </summary>
        public PostgreSqlFlexibleServerGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
        /// <summary> The earliest restore point time (ISO8601 format) for server. </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
    }
}
