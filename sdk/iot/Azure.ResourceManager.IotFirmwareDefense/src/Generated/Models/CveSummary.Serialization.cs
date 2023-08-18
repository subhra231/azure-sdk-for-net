// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveSummary
    {
        internal static CveSummary DeserializeCveSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long?> critical = default;
            Optional<long?> high = default;
            Optional<long?> medium = default;
            Optional<long?> low = default;
            Optional<long?> unknown = default;
            Optional<long?> undefined = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("critical"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        critical = null;
                        continue;
                    }
                    critical = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        high = null;
                        continue;
                    }
                    high = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("medium"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        medium = null;
                        continue;
                    }
                    medium = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        low = null;
                        continue;
                    }
                    low = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        unknown = null;
                        continue;
                    }
                    unknown = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("undefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        undefined = null;
                        continue;
                    }
                    undefined = property.Value.GetInt64();
                    continue;
                }
            }
            return new CveSummary(Optional.ToNullable(critical), Optional.ToNullable(high), Optional.ToNullable(medium), Optional.ToNullable(low), Optional.ToNullable(unknown), Optional.ToNullable(undefined));
        }
    }
}
