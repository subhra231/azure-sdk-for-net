// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A rule set which evaluates all its rules upon an event interception. Only when all the included rules in the rule set will be evaluated as 'true', will the event trigger the defined actions. </summary>
    public partial class SecurityAutomationRuleSet
    {
        /// <summary> Initializes a new instance of SecurityAutomationRuleSet. </summary>
        public SecurityAutomationRuleSet()
        {
            Rules = new ChangeTrackingList<SecurityAutomationTriggeringRule>();
        }

        /// <summary> Initializes a new instance of SecurityAutomationRuleSet. </summary>
        /// <param name="rules"></param>
        internal SecurityAutomationRuleSet(IList<SecurityAutomationTriggeringRule> rules)
        {
            Rules = rules;
        }

        /// <summary> Gets the rules. </summary>
        public IList<SecurityAutomationTriggeringRule> Rules { get; }
    }
}
