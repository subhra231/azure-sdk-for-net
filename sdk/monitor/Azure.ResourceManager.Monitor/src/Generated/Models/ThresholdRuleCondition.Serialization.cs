// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ThresholdRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToSerialString());
            writer.WritePropertyName("threshold");
            writer.WriteNumberValue(Threshold);
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize");
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            if (Optional.IsDefined(TimeAggregation))
            {
                writer.WritePropertyName("timeAggregation");
                writer.WriteStringValue(TimeAggregation.Value.ToSerialString());
            }
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource");
                writer.WriteObjectValue(DataSource);
            }
            writer.WriteEndObject();
        }

        internal static ThresholdRuleCondition DeserializeThresholdRuleCondition(JsonElement element)
        {
            MonitorConditionOperator @operator = default;
            double threshold = default;
            Optional<TimeSpan> windowSize = default;
            Optional<MonitorTimeAggregationOperator> timeAggregation = default;
            string odataType = default;
            Optional<RuleDataSource> dataSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"))
                {
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("windowSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeAggregation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeAggregation = property.Value.GetString().ToMonitorTimeAggregationOperator();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value);
                    continue;
                }
            }
            return new ThresholdRuleCondition(odataType, dataSource.Value, @operator, threshold, Optional.ToNullable(windowSize), Optional.ToNullable(timeAggregation));
        }
    }
}
