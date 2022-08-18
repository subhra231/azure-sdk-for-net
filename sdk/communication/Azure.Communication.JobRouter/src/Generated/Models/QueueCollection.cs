// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A paged collection of queues. </summary>
    internal partial class QueueCollection
    {
        /// <summary> Initializes a new instance of QueueCollection. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal QueueCollection(IEnumerable<JobQueueItem> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of QueueCollection. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal QueueCollection(IReadOnlyList<JobQueueItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<JobQueueItem> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
