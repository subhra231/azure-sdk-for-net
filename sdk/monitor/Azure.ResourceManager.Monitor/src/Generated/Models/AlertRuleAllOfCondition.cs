// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Activity Log Alert rule condition that is met when all its member conditions are met. </summary>
    internal partial class AlertRuleAllOfCondition
    {
        /// <summary> Initializes a new instance of AlertRuleAllOfCondition. </summary>
        /// <param name="allOf"> The list of Activity Log Alert rule conditions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allOf"/> is null. </exception>
        public AlertRuleAllOfCondition(IEnumerable<ActivityLogAlertAnyOfOrLeafCondition> allOf)
        {
            if (allOf == null)
            {
                throw new ArgumentNullException(nameof(allOf));
            }

            AllOf = allOf.ToList();
        }

        /// <summary> Initializes a new instance of AlertRuleAllOfCondition. </summary>
        /// <param name="allOf"> The list of Activity Log Alert rule conditions. </param>
        internal AlertRuleAllOfCondition(IList<ActivityLogAlertAnyOfOrLeafCondition> allOf)
        {
            AllOf = allOf;
        }

        /// <summary> The list of Activity Log Alert rule conditions. </summary>
        public IList<ActivityLogAlertAnyOfOrLeafCondition> AllOf { get; }
    }
}
