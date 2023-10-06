// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery point properties. </summary>
    public partial class SiteRecoveryPointProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryPointProperties. </summary>
        internal SiteRecoveryPointProperties()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryPointProperties. </summary>
        /// <param name="recoveryPointOn"> The recovery point time. </param>
        /// <param name="recoveryPointType"> The recovery point type: ApplicationConsistent, CrashConsistent. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific details for the recovery point.
        /// Please note <see cref="ProviderSpecificRecoveryPointDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ARecoveryPointDetails"/>, <see cref="InMageAzureV2RecoveryPointDetails"/> and <see cref="InMageRcmRecoveryPointDetails"/>.
        /// </param>
        internal SiteRecoveryPointProperties(DateTimeOffset? recoveryPointOn, string recoveryPointType, ProviderSpecificRecoveryPointDetails providerSpecificDetails)
        {
            RecoveryPointOn = recoveryPointOn;
            RecoveryPointType = recoveryPointType;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> The recovery point time. </summary>
        public DateTimeOffset? RecoveryPointOn { get; }
        /// <summary> The recovery point type: ApplicationConsistent, CrashConsistent. </summary>
        public string RecoveryPointType { get; }
        /// <summary>
        /// The provider specific details for the recovery point.
        /// Please note <see cref="ProviderSpecificRecoveryPointDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ARecoveryPointDetails"/>, <see cref="InMageAzureV2RecoveryPointDetails"/> and <see cref="InMageRcmRecoveryPointDetails"/>.
        /// </summary>
        public ProviderSpecificRecoveryPointDetails ProviderSpecificDetails { get; }
    }
}
