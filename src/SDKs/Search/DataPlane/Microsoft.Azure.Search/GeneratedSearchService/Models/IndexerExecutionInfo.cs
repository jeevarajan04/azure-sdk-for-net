// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the current status and execution history of an indexer.
    /// </summary>
    public partial class IndexerExecutionInfo
    {
        /// <summary>
        /// Initializes a new instance of the IndexerExecutionInfo class.
        /// </summary>
        public IndexerExecutionInfo() { }

        /// <summary>
        /// Initializes a new instance of the IndexerExecutionInfo class.
        /// </summary>
        /// <param name="status">Overall indexer status. Possible values
        /// include: 'unknown', 'error', 'running'</param>
        /// <param name="lastResult">The result of the most recent or an
        /// in-progress indexer execution.</param>
        /// <param name="executionHistory">History of the recent indexer
        /// executions, sorted in reverse chronological order.</param>
        public IndexerExecutionInfo(IndexerStatus status = default(IndexerStatus), IndexerExecutionResult lastResult = default(IndexerExecutionResult), IList<IndexerExecutionResult> executionHistory = default(IList<IndexerExecutionResult>))
        {
            Status = status;
            LastResult = lastResult;
            ExecutionHistory = executionHistory;
        }

        /// <summary>
        /// Gets overall indexer status. Possible values include: 'unknown',
        /// 'error', 'running'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public IndexerStatus Status { get; protected set; }

        /// <summary>
        /// Gets the result of the most recent or an in-progress indexer
        /// execution.
        /// </summary>
        [JsonProperty(PropertyName = "lastResult")]
        public IndexerExecutionResult LastResult { get; protected set; }

        /// <summary>
        /// Gets history of the recent indexer executions, sorted in reverse
        /// chronological order.
        /// </summary>
        [JsonProperty(PropertyName = "executionHistory")]
        public IList<IndexerExecutionResult> ExecutionHistory { get; protected set; }

    }
}
