// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the PermissionBinding resource. </summary>
    public readonly partial struct PermissionBindingProvisioningState : IEquatable<PermissionBindingProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PermissionBindingProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PermissionBindingProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string DeletedValue = "Deleted";

        /// <summary> Creating. </summary>
        public static PermissionBindingProvisioningState Creating { get; } = new PermissionBindingProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static PermissionBindingProvisioningState Updating { get; } = new PermissionBindingProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static PermissionBindingProvisioningState Deleting { get; } = new PermissionBindingProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static PermissionBindingProvisioningState Succeeded { get; } = new PermissionBindingProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static PermissionBindingProvisioningState Canceled { get; } = new PermissionBindingProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static PermissionBindingProvisioningState Failed { get; } = new PermissionBindingProvisioningState(FailedValue);
        /// <summary> Deleted. </summary>
        public static PermissionBindingProvisioningState Deleted { get; } = new PermissionBindingProvisioningState(DeletedValue);
        /// <summary> Determines if two <see cref="PermissionBindingProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PermissionBindingProvisioningState left, PermissionBindingProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PermissionBindingProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PermissionBindingProvisioningState left, PermissionBindingProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PermissionBindingProvisioningState"/>. </summary>
        public static implicit operator PermissionBindingProvisioningState(string value) => new PermissionBindingProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PermissionBindingProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PermissionBindingProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
