// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The ContainerAppJobPatchProperties. </summary>
    public partial class ContainerAppJobPatchProperties
    {
        /// <summary> Initializes a new instance of ContainerAppJobPatchProperties. </summary>
        public ContainerAppJobPatchProperties()
        {
            OutboundIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Resource ID of environment. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Container Apps Job configuration properties. </summary>
        public ContainerAppJobConfiguration Configuration { get; set; }
        /// <summary> Container Apps job definition. </summary>
        public ContainerAppJobTemplate Template { get; set; }
        /// <summary> Outbound IP Addresses of a container apps job. </summary>
        public IList<string> OutboundIPAddresses { get; }
        /// <summary> The endpoint of the eventstream of the container apps job. </summary>
        public string EventStreamEndpoint { get; set; }
    }
}
