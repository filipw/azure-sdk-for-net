// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Chat
{
    /// <summary> The cross-platform messaging notification type. </summary>
    public readonly partial struct NotificationType : IEquatable<NotificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageValue = "image";
        private const string TextValue = "text";
        private const string TemplateValue = "template";

        /// <summary> image. </summary>
        public static NotificationType Image { get; } = new NotificationType(ImageValue);
        /// <summary> text. </summary>
        public static NotificationType Text { get; } = new NotificationType(TextValue);
        /// <summary> template. </summary>
        public static NotificationType Template { get; } = new NotificationType(TemplateValue);
        /// <summary> Determines if two <see cref="NotificationType"/> values are the same. </summary>
        public static bool operator ==(NotificationType left, NotificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationType"/> values are not the same. </summary>
        public static bool operator !=(NotificationType left, NotificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationType"/>. </summary>
        public static implicit operator NotificationType(string value) => new NotificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
