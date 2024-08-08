// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Current AKS version's status: whether it is deprecated or supported. </summary>
    public readonly partial struct CurrentClusterAksVersionStatus : IEquatable<CurrentClusterAksVersionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CurrentClusterAksVersionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CurrentClusterAksVersionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeprecatedValue = "Deprecated";
        private const string SupportedValue = "Supported";

        /// <summary> Deprecated. </summary>
        public static CurrentClusterAksVersionStatus Deprecated { get; } = new CurrentClusterAksVersionStatus(DeprecatedValue);
        /// <summary> Supported. </summary>
        public static CurrentClusterAksVersionStatus Supported { get; } = new CurrentClusterAksVersionStatus(SupportedValue);
        /// <summary> Determines if two <see cref="CurrentClusterAksVersionStatus"/> values are the same. </summary>
        public static bool operator ==(CurrentClusterAksVersionStatus left, CurrentClusterAksVersionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CurrentClusterAksVersionStatus"/> values are not the same. </summary>
        public static bool operator !=(CurrentClusterAksVersionStatus left, CurrentClusterAksVersionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CurrentClusterAksVersionStatus"/>. </summary>
        public static implicit operator CurrentClusterAksVersionStatus(string value) => new CurrentClusterAksVersionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CurrentClusterAksVersionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CurrentClusterAksVersionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
