// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The credentials used to login to the image repository that has access to the specified image. </summary>
    public readonly partial struct ConsoleEnabled : IEquatable<ConsoleEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsoleEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsoleEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static ConsoleEnabled True { get; } = new ConsoleEnabled(TrueValue);
        /// <summary> False. </summary>
        public static ConsoleEnabled False { get; } = new ConsoleEnabled(FalseValue);
        /// <summary> Determines if two <see cref="ConsoleEnabled"/> values are the same. </summary>
        public static bool operator ==(ConsoleEnabled left, ConsoleEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsoleEnabled"/> values are not the same. </summary>
        public static bool operator !=(ConsoleEnabled left, ConsoleEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConsoleEnabled"/>. </summary>
        public static implicit operator ConsoleEnabled(string value) => new ConsoleEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsoleEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsoleEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
