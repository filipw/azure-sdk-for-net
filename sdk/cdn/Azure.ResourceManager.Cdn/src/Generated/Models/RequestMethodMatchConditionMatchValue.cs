// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RequestMethodMatchConditionMatchValue. </summary>
    public readonly partial struct RequestMethodMatchConditionMatchValue : IEquatable<RequestMethodMatchConditionMatchValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestMethodMatchConditionMatchValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestMethodMatchConditionMatchValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GetValue = "GET";
        private const string HeadValue = "HEAD";
        private const string PostValue = "POST";
        private const string PutValue = "PUT";
        private const string DeleteValue = "DELETE";
        private const string OptionsValue = "OPTIONS";
        private const string TraceValue = "TRACE";

        /// <summary> GET. </summary>
        public static RequestMethodMatchConditionMatchValue Get { get; } = new RequestMethodMatchConditionMatchValue(GetValue);
        /// <summary> HEAD. </summary>
        public static RequestMethodMatchConditionMatchValue Head { get; } = new RequestMethodMatchConditionMatchValue(HeadValue);
        /// <summary> POST. </summary>
        public static RequestMethodMatchConditionMatchValue Post { get; } = new RequestMethodMatchConditionMatchValue(PostValue);
        /// <summary> PUT. </summary>
        public static RequestMethodMatchConditionMatchValue Put { get; } = new RequestMethodMatchConditionMatchValue(PutValue);
        /// <summary> DELETE. </summary>
        public static RequestMethodMatchConditionMatchValue Delete { get; } = new RequestMethodMatchConditionMatchValue(DeleteValue);
        /// <summary> OPTIONS. </summary>
        public static RequestMethodMatchConditionMatchValue Options { get; } = new RequestMethodMatchConditionMatchValue(OptionsValue);
        /// <summary> TRACE. </summary>
        public static RequestMethodMatchConditionMatchValue Trace { get; } = new RequestMethodMatchConditionMatchValue(TraceValue);
        /// <summary> Determines if two <see cref="RequestMethodMatchConditionMatchValue"/> values are the same. </summary>
        public static bool operator ==(RequestMethodMatchConditionMatchValue left, RequestMethodMatchConditionMatchValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestMethodMatchConditionMatchValue"/> values are not the same. </summary>
        public static bool operator !=(RequestMethodMatchConditionMatchValue left, RequestMethodMatchConditionMatchValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestMethodMatchConditionMatchValue"/>. </summary>
        public static implicit operator RequestMethodMatchConditionMatchValue(string value) => new RequestMethodMatchConditionMatchValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestMethodMatchConditionMatchValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestMethodMatchConditionMatchValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
