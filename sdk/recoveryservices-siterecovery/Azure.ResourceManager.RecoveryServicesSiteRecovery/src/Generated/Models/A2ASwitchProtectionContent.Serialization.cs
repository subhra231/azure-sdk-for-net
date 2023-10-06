// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ASwitchProtectionContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                writer.WritePropertyName("vmManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryCloudServiceId))
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccountId))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccountId"u8);
                writer.WriteStringValue(RecoveryBootDiagStorageAccountId);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroupId))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupId"u8);
                writer.WriteStringValue(RecoveryProximityPlacementGroupId);
            }
            if (Optional.IsDefined(RecoveryVirtualMachineScaleSetId))
            {
                writer.WritePropertyName("recoveryVirtualMachineScaleSetId"u8);
                writer.WriteStringValue(RecoveryVirtualMachineScaleSetId);
            }
            if (Optional.IsDefined(RecoveryCapacityReservationGroupId))
            {
                writer.WritePropertyName("recoveryCapacityReservationGroupId"u8);
                writer.WriteStringValue(RecoveryCapacityReservationGroupId);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
