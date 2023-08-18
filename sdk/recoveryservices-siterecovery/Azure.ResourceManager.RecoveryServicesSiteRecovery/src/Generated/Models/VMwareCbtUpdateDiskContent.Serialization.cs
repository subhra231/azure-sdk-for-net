// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtUpdateDiskContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("diskId"u8);
            writer.WriteStringValue(DiskId);
            if (Optional.IsDefined(TargetDiskName))
            {
                writer.WritePropertyName("targetDiskName"u8);
                writer.WriteStringValue(TargetDiskName);
            }
            if (Optional.IsDefined(IsOSDisk))
            {
                writer.WritePropertyName("isOSDisk"u8);
                writer.WriteStringValue(IsOSDisk);
            }
            writer.WriteEndObject();
        }
    }
}
