// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveRouteMapRoute
    {
        internal static EffectiveRouteMapRoute DeserializeEffectiveRouteMapRoute(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> prefix = default;
            Optional<string> bgpCommunities = default;
            Optional<string> asPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bgpCommunities"u8))
                {
                    bgpCommunities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
            }
            return new EffectiveRouteMapRoute(prefix.Value, bgpCommunities.Value, asPath.Value);
        }
    }
}
