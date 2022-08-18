// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A list of firewall rules. </summary>
    internal partial class PostgreSqlFirewallRuleListResult
    {
        /// <summary> Initializes a new instance of PostgreSqlFirewallRuleListResult. </summary>
        internal PostgreSqlFirewallRuleListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFirewallRuleListResult. </summary>
        /// <param name="value"> The list of firewall rules in a server. </param>
        internal PostgreSqlFirewallRuleListResult(IReadOnlyList<PostgreSqlFirewallRuleData> value)
        {
            Value = value;
        }

        /// <summary> The list of firewall rules in a server. </summary>
        public IReadOnlyList<PostgreSqlFirewallRuleData> Value { get; }
    }
}
