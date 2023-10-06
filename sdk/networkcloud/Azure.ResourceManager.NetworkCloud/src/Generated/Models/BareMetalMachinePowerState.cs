// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The power state derived from the baseboard management controller. </summary>
    public readonly partial struct BareMetalMachinePowerState : IEquatable<BareMetalMachinePowerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachinePowerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BareMetalMachinePowerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static BareMetalMachinePowerState On { get; } = new BareMetalMachinePowerState(OnValue);
        /// <summary> Off. </summary>
        public static BareMetalMachinePowerState Off { get; } = new BareMetalMachinePowerState(OffValue);
        /// <summary> Determines if two <see cref="BareMetalMachinePowerState"/> values are the same. </summary>
        public static bool operator ==(BareMetalMachinePowerState left, BareMetalMachinePowerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BareMetalMachinePowerState"/> values are not the same. </summary>
        public static bool operator !=(BareMetalMachinePowerState left, BareMetalMachinePowerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BareMetalMachinePowerState"/>. </summary>
        public static implicit operator BareMetalMachinePowerState(string value) => new BareMetalMachinePowerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BareMetalMachinePowerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BareMetalMachinePowerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
