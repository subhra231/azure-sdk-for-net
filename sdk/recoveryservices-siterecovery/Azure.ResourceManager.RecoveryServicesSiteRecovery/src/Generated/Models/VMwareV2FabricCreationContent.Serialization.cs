// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareV2FabricCreationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VMwareSiteId))
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VMwareSiteId);
            }
            if (Optional.IsDefined(PhysicalSiteId))
            {
                writer.WritePropertyName("physicalSiteId"u8);
                writer.WriteStringValue(PhysicalSiteId);
            }
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
