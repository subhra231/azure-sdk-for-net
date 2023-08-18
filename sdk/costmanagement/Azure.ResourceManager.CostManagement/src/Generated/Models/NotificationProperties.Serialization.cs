// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class NotificationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("to"u8);
            writer.WriteStartArray();
            foreach (var item in To)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(RegionalFormat))
            {
                writer.WritePropertyName("regionalFormat"u8);
                writer.WriteStringValue(RegionalFormat);
            }
            writer.WritePropertyName("subject"u8);
            writer.WriteStringValue(Subject);
            writer.WriteEndObject();
        }

        internal static NotificationProperties DeserializeNotificationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> to = default;
            Optional<string> language = default;
            Optional<string> message = default;
            Optional<string> regionalFormat = default;
            string subject = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    to = array;
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalFormat"u8))
                {
                    regionalFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
            }
            return new NotificationProperties(to, language.Value, message.Value, regionalFormat.Value, subject);
        }
    }
}
