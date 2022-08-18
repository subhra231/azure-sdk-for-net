// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverPrepareContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsValidateOnly))
            {
                writer.WritePropertyName("validateOnly");
                writer.WriteBooleanValue(IsValidateOnly.Value);
            }
            writer.WritePropertyName("moveResources");
            writer.WriteStartArray();
            foreach (var item in MoveResources)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MoveResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType");
                writer.WriteStringValue(MoveResourceInputType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
