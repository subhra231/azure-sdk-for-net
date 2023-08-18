// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> RackPatchParameters represents the body of the request to patch the rack properties. </summary>
    public partial class NetworkCloudRackPatch
    {
        /// <summary> Initializes a new instance of NetworkCloudRackPatch. </summary>
        public NetworkCloudRackPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The free-form description of the rack location. (e.g. “DTN Datacenter, Floor 3, Isle 9, Rack 2B”). </summary>
        public string RackLocation { get; set; }
        /// <summary> The globally unique identifier for the rack. </summary>
        public string RackSerialNumber { get; set; }
    }
}
