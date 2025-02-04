// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    internal partial class FileDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FileFormats))
            {
                writer.WritePropertyName("fileFormats"u8);
                writer.WriteStartArray();
                foreach (var item in FileFormats)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FileDestination DeserializeFileDestination(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ScheduledActionFileFormat>> fileFormats = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileFormats"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledActionFileFormat> array = new List<ScheduledActionFileFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScheduledActionFileFormat(item.GetString()));
                    }
                    fileFormats = array;
                    continue;
                }
            }
            return new FileDestination(Optional.ToList(fileFormats));
        }
    }
}
