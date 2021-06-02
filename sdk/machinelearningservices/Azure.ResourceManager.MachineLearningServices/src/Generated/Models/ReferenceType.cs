// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Enum to determine which reference method to use for an asset. </summary>
    public readonly partial struct ReferenceType : IEquatable<ReferenceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReferenceType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IdValue = "Id";
        private const string DataPathValue = "DataPath";
        private const string OutputPathValue = "OutputPath";

        /// <summary> Id. </summary>
        public static ReferenceType Id { get; } = new ReferenceType(IdValue);
        /// <summary> DataPath. </summary>
        public static ReferenceType DataPath { get; } = new ReferenceType(DataPathValue);
        /// <summary> OutputPath. </summary>
        public static ReferenceType OutputPath { get; } = new ReferenceType(OutputPathValue);
        /// <summary> Determines if two <see cref="ReferenceType"/> values are the same. </summary>
        public static bool operator ==(ReferenceType left, ReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReferenceType"/> values are not the same. </summary>
        public static bool operator !=(ReferenceType left, ReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReferenceType"/>. </summary>
        public static implicit operator ReferenceType(string value) => new ReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
