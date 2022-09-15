// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class PlayFailed
    {
        internal static PlayFailed DeserializePlayFailed(JsonElement element)
        {
            Optional<string> eventSource = default;
            Optional<string> operationContext = default;
            Optional<ResultInformation> resultInformation = default;
            Optional<string> version = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            Optional<string> publicEventType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSource"))
                {
                    eventSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicEventType"))
                {
                    publicEventType = property.Value.GetString();
                    continue;
                }
            }
            return new PlayFailed(eventSource.Value, operationContext.Value, resultInformation.Value, version.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, publicEventType.Value);
        }
    }
}
