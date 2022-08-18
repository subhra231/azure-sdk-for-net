// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class MySqlWaitStatisticsListResult
    {
        internal static MySqlWaitStatisticsListResult DeserializeMySqlWaitStatisticsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MySqlWaitStatisticData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MySqlWaitStatisticData> array = new List<MySqlWaitStatisticData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlWaitStatisticData.DeserializeMySqlWaitStatisticData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MySqlWaitStatisticsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
