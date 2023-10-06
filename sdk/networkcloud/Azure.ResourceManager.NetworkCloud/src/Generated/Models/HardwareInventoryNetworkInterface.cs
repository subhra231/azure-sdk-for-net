// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> HardwareInventoryNetworkInterface represents the network interface details as part of a hardware inventory. </summary>
    public partial class HardwareInventoryNetworkInterface
    {
        /// <summary> Initializes a new instance of HardwareInventoryNetworkInterface. </summary>
        internal HardwareInventoryNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of HardwareInventoryNetworkInterface. </summary>
        /// <param name="linkStatus"> The current status of the link. </param>
        /// <param name="macAddress"> The MAC address associated with this interface. </param>
        /// <param name="name"> The name of the interface. </param>
        /// <param name="networkInterfaceId"> The resource ID of the network interface for the port on the switch that this machine's interface is connected to. </param>
        internal HardwareInventoryNetworkInterface(string linkStatus, string macAddress, string name, string networkInterfaceId)
        {
            LinkStatus = linkStatus;
            MacAddress = macAddress;
            Name = name;
            NetworkInterfaceId = networkInterfaceId;
        }

        /// <summary> The current status of the link. </summary>
        public string LinkStatus { get; }
        /// <summary> The MAC address associated with this interface. </summary>
        public string MacAddress { get; }
        /// <summary> The name of the interface. </summary>
        public string Name { get; }
        /// <summary> The resource ID of the network interface for the port on the switch that this machine's interface is connected to. </summary>
        public string NetworkInterfaceId { get; }
    }
}
