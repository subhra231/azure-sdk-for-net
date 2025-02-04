// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The order by expression to be used in the report. </summary>
    public partial class ReportConfigSorting
    {
        /// <summary> Initializes a new instance of ReportConfigSorting. </summary>
        /// <param name="name"> The name of the column to sort. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ReportConfigSorting(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of ReportConfigSorting. </summary>
        /// <param name="direction"> Direction of sort. </param>
        /// <param name="name"> The name of the column to sort. </param>
        internal ReportConfigSorting(ReportConfigSortingType? direction, string name)
        {
            Direction = direction;
            Name = name;
        }

        /// <summary> Direction of sort. </summary>
        public ReportConfigSortingType? Direction { get; set; }
        /// <summary> The name of the column to sort. </summary>
        public string Name { get; set; }
    }
}
