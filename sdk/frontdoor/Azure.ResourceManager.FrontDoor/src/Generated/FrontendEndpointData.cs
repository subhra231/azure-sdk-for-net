// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing the FrontendEndpoint data model.
    /// A frontend endpoint used for routing.
    /// </summary>
    public partial class FrontendEndpointData : FrontDoorResourceData
    {
        /// <summary> Initializes a new instance of FrontendEndpointData. </summary>
        public FrontendEndpointData()
        {
        }

        /// <summary> Initializes a new instance of FrontendEndpointData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="hostName"> The host name of the frontendEndpoint. Must be a domain name. </param>
        /// <param name="sessionAffinityEnabledState"> Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'. </param>
        /// <param name="sessionAffinityTtlInSeconds"> UNUSED. This field will be ignored. The TTL to use in seconds for session affinity, if applicable. </param>
        /// <param name="webApplicationFirewallPolicyLink"> Defines the Web Application Firewall policy for each host (if applicable). </param>
        /// <param name="resourceState"> Resource status. </param>
        /// <param name="customHttpsProvisioningState"> Provisioning status of Custom Https of the frontendEndpoint. </param>
        /// <param name="customHttpsProvisioningSubstate"> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. </param>
        /// <param name="customHttpsConfiguration"> The configuration specifying how to enable HTTPS. </param>
        internal FrontendEndpointData(ResourceIdentifier id, string name, ResourceType? resourceType, string hostName, SessionAffinityEnabledState? sessionAffinityEnabledState, int? sessionAffinityTtlInSeconds, WritableSubResource webApplicationFirewallPolicyLink, FrontDoorResourceState? resourceState, FrontendEndpointCustomHttpsProvisioningState? customHttpsProvisioningState, FrontendEndpointCustomHttpsProvisioningSubstate? customHttpsProvisioningSubstate, CustomHttpsConfiguration customHttpsConfiguration) : base(id, name, resourceType)
        {
            HostName = hostName;
            SessionAffinityEnabledState = sessionAffinityEnabledState;
            SessionAffinityTtlInSeconds = sessionAffinityTtlInSeconds;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            ResourceState = resourceState;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            CustomHttpsProvisioningSubstate = customHttpsProvisioningSubstate;
            CustomHttpsConfiguration = customHttpsConfiguration;
        }

        /// <summary> The host name of the frontendEndpoint. Must be a domain name. </summary>
        public string HostName { get; set; }
        /// <summary> Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'. </summary>
        public SessionAffinityEnabledState? SessionAffinityEnabledState { get; set; }
        /// <summary> UNUSED. This field will be ignored. The TTL to use in seconds for session affinity, if applicable. </summary>
        public int? SessionAffinityTtlInSeconds { get; set; }
        /// <summary> Defines the Web Application Firewall policy for each host (if applicable). </summary>
        internal WritableSubResource WebApplicationFirewallPolicyLink { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier WebApplicationFirewallPolicyLinkId
        {
            get => WebApplicationFirewallPolicyLink is null ? default : WebApplicationFirewallPolicyLink.Id;
            set
            {
                if (WebApplicationFirewallPolicyLink is null)
                    WebApplicationFirewallPolicyLink = new WritableSubResource();
                WebApplicationFirewallPolicyLink.Id = value;
            }
        }

        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
        /// <summary> Provisioning status of Custom Https of the frontendEndpoint. </summary>
        public FrontendEndpointCustomHttpsProvisioningState? CustomHttpsProvisioningState { get; }
        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. </summary>
        public FrontendEndpointCustomHttpsProvisioningSubstate? CustomHttpsProvisioningSubstate { get; }
        /// <summary> The configuration specifying how to enable HTTPS. </summary>
        public CustomHttpsConfiguration CustomHttpsConfiguration { get; }
    }
}
