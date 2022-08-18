// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines NIC IP configuration properties. </summary>
    public partial class NicIPConfigurationResourceSettings
    {
        /// <summary> Initializes a new instance of NicIPConfigurationResourceSettings. </summary>
        public NicIPConfigurationResourceSettings()
        {
            LoadBalancerBackendAddressPools = new ChangeTrackingList<LoadBalancerBackendAddressPoolReferenceInfo>();
            LoadBalancerNatRules = new ChangeTrackingList<LoadBalancerNatRuleReferenceInfo>();
        }

        /// <summary> Initializes a new instance of NicIPConfigurationResourceSettings. </summary>
        /// <param name="name"> Gets or sets the IP configuration name. </param>
        /// <param name="privateIPAddress"> Gets or sets the private IP address of the network interface IP Configuration. </param>
        /// <param name="privateIPAllocationMethod"> Gets or sets the private IP address allocation method. </param>
        /// <param name="subnet"> Defines reference to subnet. </param>
        /// <param name="isValidateOnly"> Gets or sets a value indicating whether this IP configuration is the primary. </param>
        /// <param name="loadBalancerBackendAddressPools"> Gets or sets the references of the load balancer backend address pools. </param>
        /// <param name="loadBalancerNatRules"> Gets or sets the references of the load balancer NAT rules. </param>
        /// <param name="publicIP"> Defines reference to a public IP. </param>
        internal NicIPConfigurationResourceSettings(string name, IPAddress privateIPAddress, string privateIPAllocationMethod, SubnetReferenceInfo subnet, bool? isValidateOnly, IList<LoadBalancerBackendAddressPoolReferenceInfo> loadBalancerBackendAddressPools, IList<LoadBalancerNatRuleReferenceInfo> loadBalancerNatRules, PublicIPReferenceInfo publicIP)
        {
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            IsValidateOnly = isValidateOnly;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerNatRules = loadBalancerNatRules;
            PublicIP = publicIP;
        }

        /// <summary> Gets or sets the IP configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the private IP address of the network interface IP Configuration. </summary>
        public IPAddress PrivateIPAddress { get; set; }
        /// <summary> Gets or sets the private IP address allocation method. </summary>
        public string PrivateIPAllocationMethod { get; set; }
        /// <summary> Defines reference to subnet. </summary>
        public SubnetReferenceInfo Subnet { get; set; }
        /// <summary> Gets or sets a value indicating whether this IP configuration is the primary. </summary>
        public bool? IsValidateOnly { get; set; }
        /// <summary> Gets or sets the references of the load balancer backend address pools. </summary>
        public IList<LoadBalancerBackendAddressPoolReferenceInfo> LoadBalancerBackendAddressPools { get; }
        /// <summary> Gets or sets the references of the load balancer NAT rules. </summary>
        public IList<LoadBalancerNatRuleReferenceInfo> LoadBalancerNatRules { get; }
        /// <summary> Defines reference to a public IP. </summary>
        internal PublicIPReferenceInfo PublicIP { get; set; }
        /// <summary> Gets the ARM resource ID of the tracked resource being referenced. </summary>
        public ResourceIdentifier PublicIPSourceArmResourceId
        {
            get => PublicIP is null ? default : PublicIP.SourceArmResourceId;
            set => PublicIP = new PublicIPReferenceInfo(value);
        }
    }
}
