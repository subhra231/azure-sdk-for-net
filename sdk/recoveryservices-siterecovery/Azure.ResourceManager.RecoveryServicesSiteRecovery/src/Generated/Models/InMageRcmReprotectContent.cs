// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm specific provider input. </summary>
    public partial class InMageRcmReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of InMageRcmReprotectContent. </summary>
        /// <param name="reprotectAgentId"> The reprotect agent Id. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reprotectAgentId"/>, <paramref name="datastoreName"/> or <paramref name="logStorageAccountId"/> is null. </exception>
        public InMageRcmReprotectContent(string reprotectAgentId, string datastoreName, ResourceIdentifier logStorageAccountId)
        {
            Argument.AssertNotNull(reprotectAgentId, nameof(reprotectAgentId));
            Argument.AssertNotNull(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(logStorageAccountId, nameof(logStorageAccountId));

            ReprotectAgentId = reprotectAgentId;
            DatastoreName = datastoreName;
            LogStorageAccountId = logStorageAccountId;
            InstanceType = "InMageRcm";
        }

        /// <summary> The reprotect agent Id. </summary>
        public string ReprotectAgentId { get; }
        /// <summary> The target datastore name. </summary>
        public string DatastoreName { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The Policy Id. </summary>
        public ResourceIdentifier PolicyId { get; set; }
    }
}
