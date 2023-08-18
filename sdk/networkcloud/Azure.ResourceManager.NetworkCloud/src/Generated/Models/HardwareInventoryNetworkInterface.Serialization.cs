// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class HardwareInventoryNetworkInterface
    {
        internal static HardwareInventoryNetworkInterface DeserializeHardwareInventoryNetworkInterface(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> linkStatus = default;
            Optional<string> macAddress = default;
            Optional<string> name = default;
            Optional<string> networkInterfaceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkStatus"u8))
                {
                    linkStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkInterfaceId"u8))
                {
                    networkInterfaceId = property.Value.GetString();
                    continue;
                }
            }
            return new HardwareInventoryNetworkInterface(linkStatus.Value, macAddress.Value, name.Value, networkInterfaceId.Value);
        }
    }
}
