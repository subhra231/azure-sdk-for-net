// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DesktopVirtualization. </summary>
    public static partial class DesktopVirtualizationExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region VirtualWorkspaceResource
        /// <summary>
        /// Gets an object representing a <see cref="VirtualWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="VirtualWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualWorkspaceResource" /> object. </returns>
        public static VirtualWorkspaceResource GetVirtualWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualWorkspaceResource.ValidateResourceId(id);
                return new VirtualWorkspaceResource(client, id);
            }
            );
        }
        #endregion

        #region ScalingPlanResource
        /// <summary>
        /// Gets an object representing a <see cref="ScalingPlanResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScalingPlanResource.CreateResourceIdentifier" /> to create a <see cref="ScalingPlanResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScalingPlanResource" /> object. </returns>
        public static ScalingPlanResource GetScalingPlanResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScalingPlanResource.ValidateResourceId(id);
                return new ScalingPlanResource(client, id);
            }
            );
        }
        #endregion

        #region ScalingPlanPooledScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="ScalingPlanPooledScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScalingPlanPooledScheduleResource.CreateResourceIdentifier" /> to create a <see cref="ScalingPlanPooledScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScalingPlanPooledScheduleResource" /> object. </returns>
        public static ScalingPlanPooledScheduleResource GetScalingPlanPooledScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScalingPlanPooledScheduleResource.ValidateResourceId(id);
                return new ScalingPlanPooledScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualApplicationGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="VirtualApplicationGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualApplicationGroupResource.CreateResourceIdentifier" /> to create a <see cref="VirtualApplicationGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualApplicationGroupResource" /> object. </returns>
        public static VirtualApplicationGroupResource GetVirtualApplicationGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualApplicationGroupResource.ValidateResourceId(id);
                return new VirtualApplicationGroupResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualApplicationResource
        /// <summary>
        /// Gets an object representing a <see cref="VirtualApplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualApplicationResource.CreateResourceIdentifier" /> to create a <see cref="VirtualApplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualApplicationResource" /> object. </returns>
        public static VirtualApplicationResource GetVirtualApplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualApplicationResource.ValidateResourceId(id);
                return new VirtualApplicationResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualDesktopResource
        /// <summary>
        /// Gets an object representing a <see cref="VirtualDesktopResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualDesktopResource.CreateResourceIdentifier" /> to create a <see cref="VirtualDesktopResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualDesktopResource" /> object. </returns>
        public static VirtualDesktopResource GetVirtualDesktopResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualDesktopResource.ValidateResourceId(id);
                return new VirtualDesktopResource(client, id);
            }
            );
        }
        #endregion

        #region HostPoolResource
        /// <summary>
        /// Gets an object representing a <see cref="HostPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HostPoolResource.CreateResourceIdentifier" /> to create a <see cref="HostPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HostPoolResource" /> object. </returns>
        public static HostPoolResource GetHostPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HostPoolResource.ValidateResourceId(id);
                return new HostPoolResource(client, id);
            }
            );
        }
        #endregion

        #region UserSessionResource
        /// <summary>
        /// Gets an object representing an <see cref="UserSessionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UserSessionResource.CreateResourceIdentifier" /> to create an <see cref="UserSessionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UserSessionResource" /> object. </returns>
        public static UserSessionResource GetUserSessionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                UserSessionResource.ValidateResourceId(id);
                return new UserSessionResource(client, id);
            }
            );
        }
        #endregion

        #region SessionHostResource
        /// <summary>
        /// Gets an object representing a <see cref="SessionHostResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SessionHostResource.CreateResourceIdentifier" /> to create a <see cref="SessionHostResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SessionHostResource" /> object. </returns>
        public static SessionHostResource GetSessionHostResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SessionHostResource.ValidateResourceId(id);
                return new SessionHostResource(client, id);
            }
            );
        }
        #endregion

        #region MsixPackageResource
        /// <summary>
        /// Gets an object representing a <see cref="MsixPackageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MsixPackageResource.CreateResourceIdentifier" /> to create a <see cref="MsixPackageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MsixPackageResource" /> object. </returns>
        public static MsixPackageResource GetMsixPackageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MsixPackageResource.ValidateResourceId(id);
                return new MsixPackageResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of VirtualWorkspaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualWorkspaceResources and their operations over a VirtualWorkspaceResource. </returns>
        public static VirtualWorkspaceCollection GetVirtualWorkspaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetVirtualWorkspaces();
        }

        /// <summary>
        /// Get a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<VirtualWorkspaceResource>> GetVirtualWorkspaceAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetVirtualWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<VirtualWorkspaceResource> GetVirtualWorkspace(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetVirtualWorkspaces().Get(workspaceName, cancellationToken);
        }

        /// <summary> Gets a collection of ScalingPlanResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScalingPlanResources and their operations over a ScalingPlanResource. </returns>
        public static ScalingPlanCollection GetScalingPlans(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetScalingPlans();
        }

        /// <summary>
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScalingPlanResource>> GetScalingPlanAsync(this ResourceGroupResource resourceGroupResource, string scalingPlanName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScalingPlans().GetAsync(scalingPlanName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScalingPlanResource> GetScalingPlan(this ResourceGroupResource resourceGroupResource, string scalingPlanName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScalingPlans().Get(scalingPlanName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualApplicationGroupResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualApplicationGroupResources and their operations over a VirtualApplicationGroupResource. </returns>
        public static VirtualApplicationGroupCollection GetVirtualApplicationGroups(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetVirtualApplicationGroups();
        }

        /// <summary>
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<VirtualApplicationGroupResource>> GetVirtualApplicationGroupAsync(this ResourceGroupResource resourceGroupResource, string applicationGroupName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetVirtualApplicationGroups().GetAsync(applicationGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<VirtualApplicationGroupResource> GetVirtualApplicationGroup(this ResourceGroupResource resourceGroupResource, string applicationGroupName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetVirtualApplicationGroups().Get(applicationGroupName, cancellationToken);
        }

        /// <summary> Gets a collection of HostPoolResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HostPoolResources and their operations over a HostPoolResource. </returns>
        public static HostPoolCollection GetHostPools(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetHostPools();
        }

        /// <summary>
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HostPoolResource>> GetHostPoolAsync(this ResourceGroupResource resourceGroupResource, string hostPoolName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetHostPools().GetAsync(hostPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HostPoolResource> GetHostPool(this ResourceGroupResource resourceGroupResource, string hostPoolName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetHostPools().Get(hostPoolName, cancellationToken);
        }

        /// <summary>
        /// List workspaces in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualWorkspaceResource> GetVirtualWorkspacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetVirtualWorkspacesAsync(cancellationToken);
        }

        /// <summary>
        /// List workspaces in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualWorkspaceResource> GetVirtualWorkspaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetVirtualWorkspaces(cancellationToken);
        }

        /// <summary>
        /// List scaling plans in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScalingPlanResource> GetScalingPlansAsync(this SubscriptionResource subscriptionResource, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetScalingPlansAsync(pageSize, isDescending, initialSkip, cancellationToken);
        }

        /// <summary>
        /// List scaling plans in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScalingPlanResource> GetScalingPlans(this SubscriptionResource subscriptionResource, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetScalingPlans(pageSize, isDescending, initialSkip, cancellationToken);
        }

        /// <summary>
        /// List applicationGroups in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualApplicationGroupResource> GetVirtualApplicationGroupsAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetVirtualApplicationGroupsAsync(filter, cancellationToken);
        }

        /// <summary>
        /// List applicationGroups in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualApplicationGroupResource> GetVirtualApplicationGroups(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetVirtualApplicationGroups(filter, cancellationToken);
        }

        /// <summary>
        /// List hostPools in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HostPoolResource> GetHostPoolsAsync(this SubscriptionResource subscriptionResource, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetHostPoolsAsync(pageSize, isDescending, initialSkip, cancellationToken);
        }

        /// <summary>
        /// List hostPools in subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HostPoolResource> GetHostPools(this SubscriptionResource subscriptionResource, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetHostPools(pageSize, isDescending, initialSkip, cancellationToken);
        }
    }
}
