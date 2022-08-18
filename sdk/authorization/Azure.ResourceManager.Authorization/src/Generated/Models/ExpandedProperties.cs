// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The ExpandedProperties. </summary>
    public partial class ExpandedProperties : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ExpandedProperties. </summary>
        /// <param name="location"> The location. </param>
        internal ExpandedProperties(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ExpandedProperties. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="principalId"> Id of the principal. </param>
        /// <param name="principalDisplayName"> Display name of the principal. </param>
        /// <param name="email"> Email id of the principal. </param>
        /// <param name="principalType"> Type of the principal. </param>
        /// <param name="roleDefinitionId"> Id of the role definition. </param>
        /// <param name="roleDefinitionDisplayName"> Display name of the role definition. </param>
        /// <param name="roleDefinitionType"> Type of the role definition. </param>
        /// <param name="scopeId"> Scope id of the resource. </param>
        /// <param name="scopeDisplayName"> Display name of the resource. </param>
        /// <param name="scopeType"> Type of the resource. </param>
        internal ExpandedProperties(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? principalId, string principalDisplayName, string email, string principalType, ResourceIdentifier roleDefinitionId, string roleDefinitionDisplayName, string roleDefinitionType, ResourceIdentifier scopeId, string scopeDisplayName, string scopeType) : base(id, name, resourceType, systemData, tags, location)
        {
            PrincipalId = principalId;
            PrincipalDisplayName = principalDisplayName;
            Email = email;
            PrincipalType = principalType;
            RoleDefinitionId = roleDefinitionId;
            RoleDefinitionDisplayName = roleDefinitionDisplayName;
            RoleDefinitionType = roleDefinitionType;
            ScopeId = scopeId;
            ScopeDisplayName = scopeDisplayName;
            ScopeType = scopeType;
        }

        /// <summary> Id of the principal. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> Display name of the principal. </summary>
        public string PrincipalDisplayName { get; }
        /// <summary> Email id of the principal. </summary>
        public string Email { get; }
        /// <summary> Type of the principal. </summary>
        public string PrincipalType { get; }
        /// <summary> Id of the role definition. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> Display name of the role definition. </summary>
        public string RoleDefinitionDisplayName { get; }
        /// <summary> Type of the role definition. </summary>
        public string RoleDefinitionType { get; }
        /// <summary> Scope id of the resource. </summary>
        public ResourceIdentifier ScopeId { get; }
        /// <summary> Display name of the resource. </summary>
        public string ScopeDisplayName { get; }
        /// <summary> Type of the resource. </summary>
        public string ScopeType { get; }
    }
}
