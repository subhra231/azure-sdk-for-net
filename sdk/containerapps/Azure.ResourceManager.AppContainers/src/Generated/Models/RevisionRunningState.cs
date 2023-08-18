// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Current running state of the revision. </summary>
    public readonly partial struct RevisionRunningState : IEquatable<RevisionRunningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RevisionRunningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RevisionRunningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string ProcessingValue = "Processing";
        private const string StoppedValue = "Stopped";
        private const string DegradedValue = "Degraded";
        private const string FailedValue = "Failed";
        private const string UnknownValue = "Unknown";

        /// <summary> Running. </summary>
        public static RevisionRunningState Running { get; } = new RevisionRunningState(RunningValue);
        /// <summary> Processing. </summary>
        public static RevisionRunningState Processing { get; } = new RevisionRunningState(ProcessingValue);
        /// <summary> Stopped. </summary>
        public static RevisionRunningState Stopped { get; } = new RevisionRunningState(StoppedValue);
        /// <summary> Degraded. </summary>
        public static RevisionRunningState Degraded { get; } = new RevisionRunningState(DegradedValue);
        /// <summary> Failed. </summary>
        public static RevisionRunningState Failed { get; } = new RevisionRunningState(FailedValue);
        /// <summary> Unknown. </summary>
        public static RevisionRunningState Unknown { get; } = new RevisionRunningState(UnknownValue);
        /// <summary> Determines if two <see cref="RevisionRunningState"/> values are the same. </summary>
        public static bool operator ==(RevisionRunningState left, RevisionRunningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RevisionRunningState"/> values are not the same. </summary>
        public static bool operator !=(RevisionRunningState left, RevisionRunningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RevisionRunningState"/>. </summary>
        public static implicit operator RevisionRunningState(string value) => new RevisionRunningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RevisionRunningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RevisionRunningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
