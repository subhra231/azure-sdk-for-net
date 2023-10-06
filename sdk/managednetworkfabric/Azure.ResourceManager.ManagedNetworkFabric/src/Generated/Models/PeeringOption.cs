// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Peering option list. </summary>
    public readonly partial struct PeeringOption : IEquatable<PeeringOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OptionAValue = "OptionA";
        private const string OptionBValue = "OptionB";

        /// <summary> OptionA. </summary>
        public static PeeringOption OptionA { get; } = new PeeringOption(OptionAValue);
        /// <summary> OptionB. </summary>
        public static PeeringOption OptionB { get; } = new PeeringOption(OptionBValue);
        /// <summary> Determines if two <see cref="PeeringOption"/> values are the same. </summary>
        public static bool operator ==(PeeringOption left, PeeringOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringOption"/> values are not the same. </summary>
        public static bool operator !=(PeeringOption left, PeeringOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PeeringOption"/>. </summary>
        public static implicit operator PeeringOption(string value) => new PeeringOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
