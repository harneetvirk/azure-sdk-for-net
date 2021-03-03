// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Cassandra keyspaces and their properties. </summary>
    internal partial class CassandraKeyspaceListResult
    {
        /// <summary> Initializes a new instance of CassandraKeyspaceListResult. </summary>
        internal CassandraKeyspaceListResult()
        {
            Value = new ChangeTrackingList<CassandraKeyspaceGetResults>();
        }

        /// <summary> Initializes a new instance of CassandraKeyspaceListResult. </summary>
        /// <param name="value"> List of Cassandra keyspaces and their properties. </param>
        internal CassandraKeyspaceListResult(IReadOnlyList<CassandraKeyspaceGetResults> value)
        {
            Value = value;
        }

        /// <summary> List of Cassandra keyspaces and their properties. </summary>
        public IReadOnlyList<CassandraKeyspaceGetResults> Value { get; }
    }
}
