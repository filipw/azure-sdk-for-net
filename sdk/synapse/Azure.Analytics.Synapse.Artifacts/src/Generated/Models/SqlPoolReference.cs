// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SQL pool reference type. </summary>
    public partial class SqlPoolReference
    {
        /// <summary> Initializes a new instance of <see cref="SqlPoolReference"/>. </summary>
        /// <param name="type"> SQL pool reference type. </param>
        /// <param name="referenceName"> Reference SQL pool name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SqlPoolReference(SqlPoolReferenceType type, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> SQL pool reference type. </summary>
        public SqlPoolReferenceType Type { get; set; }
        /// <summary> Reference SQL pool name. </summary>
        public string ReferenceName { get; set; }
    }
}
