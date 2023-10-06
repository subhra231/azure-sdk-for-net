// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Contains details of errors encountered during a job execution. </summary>
    internal partial class DocumentError
    {
        /// <summary> Initializes a new instance of DocumentError. </summary>
        /// <param name="id"> The ID of the input document. </param>
        /// <param name="error"> Error encountered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="error"/> is null. </exception>
        public DocumentError(string id, Error error)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(error, nameof(error));

            Id = id;
            Error = error;
        }

        /// <summary> The ID of the input document. </summary>
        public string Id { get; set; }
        /// <summary> Error encountered. </summary>
        public Error Error { get; set; }
    }
}
