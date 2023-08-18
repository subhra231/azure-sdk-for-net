// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The properties used to create a new server. </summary>
    public partial class PostgreSqlServerPropertiesForDefaultCreate : PostgreSqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of PostgreSqlServerPropertiesForDefaultCreate. </summary>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="administratorLogin"/> or <paramref name="administratorLoginPassword"/> is null. </exception>
        public PostgreSqlServerPropertiesForDefaultCreate(string administratorLogin, string administratorLoginPassword)
        {
            Argument.AssertNotNull(administratorLogin, nameof(administratorLogin));
            Argument.AssertNotNull(administratorLoginPassword, nameof(administratorLoginPassword));

            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            CreateMode = PostgreSqlCreateMode.Default;
        }

        /// <summary> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; }
    }
}
