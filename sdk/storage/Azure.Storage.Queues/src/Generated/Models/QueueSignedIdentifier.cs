// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> signed identifier. </summary>
    public partial class QueueSignedIdentifier
    {
        /// <summary> a unique id. </summary>
        public string Id { get; set; }
        /// <summary> The access policy. </summary>
        public QueueAccessPolicy AccessPolicy { get; set; }
    }
}
