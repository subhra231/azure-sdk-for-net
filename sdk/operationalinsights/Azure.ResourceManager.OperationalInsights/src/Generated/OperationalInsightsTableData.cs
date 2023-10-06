// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the OperationalInsightsTable data model.
    /// Workspace data table definition.
    /// </summary>
    public partial class OperationalInsightsTableData : ResourceData
    {
        /// <summary> Initializes a new instance of OperationalInsightsTableData. </summary>
        public OperationalInsightsTableData()
        {
        }

        /// <summary> Initializes a new instance of OperationalInsightsTableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="retentionInDays"> The table retention in days, between 4 and 730. Setting this property to -1 will default to the workspace retention. </param>
        /// <param name="totalRetentionInDays"> The table total retention in days, between 4 and 2555. Setting this property to -1 will default to table retention. </param>
        /// <param name="archiveRetentionInDays"> The table data archive retention in days. Calculated as (totalRetentionInDays-retentionInDays). </param>
        /// <param name="searchResults"> Parameters of the search job that initiated this table. </param>
        /// <param name="restoredLogs"> Parameters of the restore operation that initiated this table. </param>
        /// <param name="resultStatistics"> Search job execution statistics. </param>
        /// <param name="plan"> Instruct the system how to handle and charge the logs ingested to this table. </param>
        /// <param name="lastPlanModifiedDate"> The timestamp that table plan was last modified (UTC). </param>
        /// <param name="schema"> Table schema. </param>
        /// <param name="provisioningState"> Table's current provisioning state. If set to 'updating', indicates a resource lock due to ongoing operation, forbidding any update to the table until the ongoing operation is concluded. </param>
        /// <param name="retentionInDaysAsDefault"> True - Value originates from workspace retention in days, False - Customer specific. </param>
        /// <param name="totalRetentionInDaysAsDefault"> True - Value originates from retention in days, False - Customer specific. </param>
        internal OperationalInsightsTableData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? retentionInDays, int? totalRetentionInDays, int? archiveRetentionInDays, OperationalInsightsTableSearchResults searchResults, OperationalInsightsTableRestoredLogs restoredLogs, OperationalInsightsTableResultStatistics resultStatistics, OperationalInsightsTablePlan? plan, string lastPlanModifiedDate, OperationalInsightsSchema schema, OperationalInsightsTableProvisioningState? provisioningState, RetentionInDaysAsDefaultState? retentionInDaysAsDefault, TotalRetentionInDaysAsDefaultState? totalRetentionInDaysAsDefault) : base(id, name, resourceType, systemData)
        {
            RetentionInDays = retentionInDays;
            TotalRetentionInDays = totalRetentionInDays;
            ArchiveRetentionInDays = archiveRetentionInDays;
            SearchResults = searchResults;
            RestoredLogs = restoredLogs;
            ResultStatistics = resultStatistics;
            Plan = plan;
            LastPlanModifiedDate = lastPlanModifiedDate;
            Schema = schema;
            ProvisioningState = provisioningState;
            RetentionInDaysAsDefault = retentionInDaysAsDefault;
            TotalRetentionInDaysAsDefault = totalRetentionInDaysAsDefault;
        }

        /// <summary> The table retention in days, between 4 and 730. Setting this property to -1 will default to the workspace retention. </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> The table total retention in days, between 4 and 2555. Setting this property to -1 will default to table retention. </summary>
        public int? TotalRetentionInDays { get; set; }
        /// <summary> The table data archive retention in days. Calculated as (totalRetentionInDays-retentionInDays). </summary>
        public int? ArchiveRetentionInDays { get; }
        /// <summary> Parameters of the search job that initiated this table. </summary>
        public OperationalInsightsTableSearchResults SearchResults { get; set; }
        /// <summary> Parameters of the restore operation that initiated this table. </summary>
        public OperationalInsightsTableRestoredLogs RestoredLogs { get; set; }
        /// <summary> Search job execution statistics. </summary>
        public OperationalInsightsTableResultStatistics ResultStatistics { get; }
        /// <summary> Instruct the system how to handle and charge the logs ingested to this table. </summary>
        public OperationalInsightsTablePlan? Plan { get; set; }
        /// <summary> The timestamp that table plan was last modified (UTC). </summary>
        public string LastPlanModifiedDate { get; }
        /// <summary> Table schema. </summary>
        public OperationalInsightsSchema Schema { get; set; }
        /// <summary> Table's current provisioning state. If set to 'updating', indicates a resource lock due to ongoing operation, forbidding any update to the table until the ongoing operation is concluded. </summary>
        public OperationalInsightsTableProvisioningState? ProvisioningState { get; }
        /// <summary> True - Value originates from workspace retention in days, False - Customer specific. </summary>
        public RetentionInDaysAsDefaultState? RetentionInDaysAsDefault { get; }
        /// <summary> True - Value originates from retention in days, False - Customer specific. </summary>
        public TotalRetentionInDaysAsDefaultState? TotalRetentionInDaysAsDefault { get; }
    }
}
