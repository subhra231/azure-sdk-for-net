// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> IaaS VM workload-specific backup policy. </summary>
    public partial class IaasVmProtectionPolicy : BackupGenericProtectionPolicy
    {
        /// <summary> Initializes a new instance of IaasVmProtectionPolicy. </summary>
        public IaasVmProtectionPolicy()
        {
            TieringPolicy = new ChangeTrackingDictionary<string, BackupTieringPolicy>();
            BackupManagementType = "AzureIaasVM";
        }

        /// <summary> Initializes a new instance of IaasVmProtectionPolicy. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="instantRPDetails"></param>
        /// <param name="schedulePolicy">
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </param>
        /// <param name="retentionPolicy">
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </param>
        /// <param name="tieringPolicy">
        /// Tiering policy to automatically move RPs to another tier
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </param>
        /// <param name="instantRPRetentionRangeInDays"> Instant RP retention policy range in days. </param>
        /// <param name="timeZone"> TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time". </param>
        /// <param name="policyType"></param>
        internal IaasVmProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, InstantRPAdditionalDetails instantRPDetails, BackupSchedulePolicy schedulePolicy, BackupRetentionPolicy retentionPolicy, IDictionary<string, BackupTieringPolicy> tieringPolicy, int? instantRPRetentionRangeInDays, string timeZone, IaasVmPolicyType? policyType) : base(protectedItemsCount, backupManagementType, resourceGuardOperationRequests)
        {
            InstantRPDetails = instantRPDetails;
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            TieringPolicy = tieringPolicy;
            InstantRPRetentionRangeInDays = instantRPRetentionRangeInDays;
            TimeZone = timeZone;
            PolicyType = policyType;
            BackupManagementType = backupManagementType ?? "AzureIaasVM";
        }

        /// <summary> Gets or sets the instant rp details. </summary>
        public InstantRPAdditionalDetails InstantRPDetails { get; set; }
        /// <summary>
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </summary>
        public BackupSchedulePolicy SchedulePolicy { get; set; }
        /// <summary>
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </summary>
        public BackupRetentionPolicy RetentionPolicy { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        public IDictionary<string, BackupTieringPolicy> TieringPolicy { get; }
        /// <summary> Instant RP retention policy range in days. </summary>
        public int? InstantRPRetentionRangeInDays { get; set; }
        /// <summary> TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time". </summary>
        public string TimeZone { get; set; }
        /// <summary> Gets or sets the policy type. </summary>
        public IaasVmPolicyType? PolicyType { get; set; }
    }
}
