// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NewRelicObservability
{
    internal class NewRelicObservabilityTagRuleOperationSource : IOperationSource<NewRelicObservabilityTagRuleResource>
    {
        private readonly ArmClient _client;

        internal NewRelicObservabilityTagRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        NewRelicObservabilityTagRuleResource IOperationSource<NewRelicObservabilityTagRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NewRelicObservabilityTagRuleData.DeserializeNewRelicObservabilityTagRuleData(document.RootElement);
            return new NewRelicObservabilityTagRuleResource(_client, data);
        }

        async ValueTask<NewRelicObservabilityTagRuleResource> IOperationSource<NewRelicObservabilityTagRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NewRelicObservabilityTagRuleData.DeserializeNewRelicObservabilityTagRuleData(document.RootElement);
            return new NewRelicObservabilityTagRuleResource(_client, data);
        }
    }
}
