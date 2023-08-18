// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPortReuseHoldTimes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteNumberValue(Tcp.Value);
            }
            if (Optional.IsDefined(Udp))
            {
                writer.WritePropertyName("udp"u8);
                writer.WriteNumberValue(Udp.Value);
            }
            writer.WriteEndObject();
        }

        internal static MobileNetworkPortReuseHoldTimes DeserializeMobileNetworkPortReuseHoldTimes(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> tcp = default;
            Optional<int> udp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udp = property.Value.GetInt32();
                    continue;
                }
            }
            return new MobileNetworkPortReuseHoldTimes(Optional.ToNullable(tcp), Optional.ToNullable(udp));
        }
    }
}
