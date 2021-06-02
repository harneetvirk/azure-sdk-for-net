// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the VNet/subnet policy if applicable. </summary>
    public readonly partial struct SshPublicAccess : IEquatable<SshPublicAccess>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SshPublicAccess"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SshPublicAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SshPublicAccess Enabled { get; } = new SshPublicAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SshPublicAccess Disabled { get; } = new SshPublicAccess(DisabledValue);
        /// <summary> Determines if two <see cref="SshPublicAccess"/> values are the same. </summary>
        public static bool operator ==(SshPublicAccess left, SshPublicAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SshPublicAccess"/> values are not the same. </summary>
        public static bool operator !=(SshPublicAccess left, SshPublicAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SshPublicAccess"/>. </summary>
        public static implicit operator SshPublicAccess(string value) => new SshPublicAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SshPublicAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SshPublicAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
