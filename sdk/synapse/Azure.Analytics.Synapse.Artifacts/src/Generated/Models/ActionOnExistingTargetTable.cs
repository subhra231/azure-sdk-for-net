// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Action on existing target table. If not specified, 'FailOnNonEmptyTable' action is used. </summary>
    public readonly partial struct ActionOnExistingTargetTable : IEquatable<ActionOnExistingTargetTable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ActionOnExistingTargetTable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionOnExistingTargetTable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FailOnNonEmptyTableValue = "FailOnNonEmptyTable";
        private const string DropAndRecreateTableValue = "DropAndRecreateTable";
        private const string MergeWithExistingDataValue = "MergeWithExistingData";

        /// <summary> Same existing tables on target database will be Failed. </summary>
        public static ActionOnExistingTargetTable FailOnNonEmptyTable { get; } = new ActionOnExistingTargetTable(FailOnNonEmptyTableValue);
        /// <summary> Same existing tables on target database will be dropped and recreated. </summary>
        public static ActionOnExistingTargetTable DropAndRecreateTable { get; } = new ActionOnExistingTargetTable(DropAndRecreateTableValue);
        /// <summary> Same existing tables on target database will be Merged together. </summary>
        public static ActionOnExistingTargetTable MergeWithExistingData { get; } = new ActionOnExistingTargetTable(MergeWithExistingDataValue);
        /// <summary> Determines if two <see cref="ActionOnExistingTargetTable"/> values are the same. </summary>
        public static bool operator ==(ActionOnExistingTargetTable left, ActionOnExistingTargetTable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionOnExistingTargetTable"/> values are not the same. </summary>
        public static bool operator !=(ActionOnExistingTargetTable left, ActionOnExistingTargetTable right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ActionOnExistingTargetTable"/>. </summary>
        public static implicit operator ActionOnExistingTargetTable(string value) => new ActionOnExistingTargetTable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionOnExistingTargetTable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionOnExistingTargetTable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
