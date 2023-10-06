// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AUnplannedFailoverContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(CloudServiceCreationOption))
            {
                writer.WritePropertyName("cloudServiceCreationOption"u8);
                writer.WriteStringValue(CloudServiceCreationOption);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
