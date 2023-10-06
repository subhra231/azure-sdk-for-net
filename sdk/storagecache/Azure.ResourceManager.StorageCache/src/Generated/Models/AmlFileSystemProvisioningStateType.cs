// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> ARM provisioning state. </summary>
    public readonly partial struct AmlFileSystemProvisioningStateType : IEquatable<AmlFileSystemProvisioningStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemProvisioningStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AmlFileSystemProvisioningStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static AmlFileSystemProvisioningStateType Succeeded { get; } = new AmlFileSystemProvisioningStateType(SucceededValue);
        /// <summary> Failed. </summary>
        public static AmlFileSystemProvisioningStateType Failed { get; } = new AmlFileSystemProvisioningStateType(FailedValue);
        /// <summary> Creating. </summary>
        public static AmlFileSystemProvisioningStateType Creating { get; } = new AmlFileSystemProvisioningStateType(CreatingValue);
        /// <summary> Deleting. </summary>
        public static AmlFileSystemProvisioningStateType Deleting { get; } = new AmlFileSystemProvisioningStateType(DeletingValue);
        /// <summary> Updating. </summary>
        public static AmlFileSystemProvisioningStateType Updating { get; } = new AmlFileSystemProvisioningStateType(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static AmlFileSystemProvisioningStateType Canceled { get; } = new AmlFileSystemProvisioningStateType(CanceledValue);
        /// <summary> Determines if two <see cref="AmlFileSystemProvisioningStateType"/> values are the same. </summary>
        public static bool operator ==(AmlFileSystemProvisioningStateType left, AmlFileSystemProvisioningStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AmlFileSystemProvisioningStateType"/> values are not the same. </summary>
        public static bool operator !=(AmlFileSystemProvisioningStateType left, AmlFileSystemProvisioningStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AmlFileSystemProvisioningStateType"/>. </summary>
        public static implicit operator AmlFileSystemProvisioningStateType(string value) => new AmlFileSystemProvisioningStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AmlFileSystemProvisioningStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AmlFileSystemProvisioningStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
