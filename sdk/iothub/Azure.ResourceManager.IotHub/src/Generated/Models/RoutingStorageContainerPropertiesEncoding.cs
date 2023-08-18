// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Encoding that is used to serialize messages to blobs. Supported values are 'avro', 'avrodeflate', and 'JSON'. Default value is 'avro'. </summary>
    public readonly partial struct RoutingStorageContainerPropertiesEncoding : IEquatable<RoutingStorageContainerPropertiesEncoding>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoutingStorageContainerPropertiesEncoding"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoutingStorageContainerPropertiesEncoding(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvroValue = "Avro";
        private const string AvroDeflateValue = "AvroDeflate";
        private const string JsonValue = "JSON";

        /// <summary> Avro. </summary>
        public static RoutingStorageContainerPropertiesEncoding Avro { get; } = new RoutingStorageContainerPropertiesEncoding(AvroValue);
        /// <summary> AvroDeflate. </summary>
        public static RoutingStorageContainerPropertiesEncoding AvroDeflate { get; } = new RoutingStorageContainerPropertiesEncoding(AvroDeflateValue);
        /// <summary> JSON. </summary>
        public static RoutingStorageContainerPropertiesEncoding Json { get; } = new RoutingStorageContainerPropertiesEncoding(JsonValue);
        /// <summary> Determines if two <see cref="RoutingStorageContainerPropertiesEncoding"/> values are the same. </summary>
        public static bool operator ==(RoutingStorageContainerPropertiesEncoding left, RoutingStorageContainerPropertiesEncoding right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoutingStorageContainerPropertiesEncoding"/> values are not the same. </summary>
        public static bool operator !=(RoutingStorageContainerPropertiesEncoding left, RoutingStorageContainerPropertiesEncoding right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoutingStorageContainerPropertiesEncoding"/>. </summary>
        public static implicit operator RoutingStorageContainerPropertiesEncoding(string value) => new RoutingStorageContainerPropertiesEncoding(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoutingStorageContainerPropertiesEncoding other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoutingStorageContainerPropertiesEncoding other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
