// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> HostPool type for desktop. </summary>
    public readonly partial struct ScalingHostPoolType : IEquatable<ScalingHostPoolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScalingHostPoolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScalingHostPoolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PooledValue = "Pooled";

        /// <summary> Users get a new (random) SessionHost every time it connects to the HostPool. </summary>
        public static ScalingHostPoolType Pooled { get; } = new ScalingHostPoolType(PooledValue);
        /// <summary> Determines if two <see cref="ScalingHostPoolType"/> values are the same. </summary>
        public static bool operator ==(ScalingHostPoolType left, ScalingHostPoolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScalingHostPoolType"/> values are not the same. </summary>
        public static bool operator !=(ScalingHostPoolType left, ScalingHostPoolType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScalingHostPoolType"/>. </summary>
        public static implicit operator ScalingHostPoolType(string value) => new ScalingHostPoolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScalingHostPoolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScalingHostPoolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
