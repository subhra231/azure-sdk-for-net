// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The aggregation expression to be used in the report. </summary>
    public partial class ReportConfigAggregation
    {
        /// <summary> Initializes a new instance of ReportConfigAggregation. </summary>
        /// <param name="name"> The name of the column to aggregate. </param>
        /// <param name="function"> The name of the aggregation function to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ReportConfigAggregation(string name, FunctionType function)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Function = function;
        }

        /// <summary> The name of the column to aggregate. </summary>
        public string Name { get; set; }
        /// <summary> The name of the aggregation function to use. </summary>
        public FunctionType Function { get; set; }
    }
}
