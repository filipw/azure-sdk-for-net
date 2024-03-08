// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Run notebook snapshot result. </summary>
    public partial class RunNotebookSnapshotResult
    {
        /// <summary> Initializes a new instance of <see cref="RunNotebookSnapshotResult"/>. </summary>
        /// <param name="snapshot"> Run notebook snapshot. </param>
        /// <param name="runId"> Run id. </param>
        /// <param name="runStatus"> Status of the run notebook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshot"/>, <paramref name="runId"/> or <paramref name="runStatus"/> is null. </exception>
        internal RunNotebookSnapshotResult(RunNotebookSnapshot snapshot, string runId, string runStatus)
        {
            Argument.AssertNotNull(snapshot, nameof(snapshot));
            Argument.AssertNotNull(runId, nameof(runId));
            Argument.AssertNotNull(runStatus, nameof(runStatus));

            Snapshot = snapshot;
            RunId = runId;
            RunStatus = runStatus;
        }

        /// <summary> Initializes a new instance of <see cref="RunNotebookSnapshotResult"/>. </summary>
        /// <param name="snapshot"> Run notebook snapshot. </param>
        /// <param name="error"> Run notebook error. </param>
        /// <param name="runId"> Run id. </param>
        /// <param name="runStatus"> Status of the run notebook. </param>
        /// <param name="lastCheckedOn"> Timestamp of last update. </param>
        /// <param name="sessionId"> Livy session id. </param>
        /// <param name="sparkPool"> SparkPool name. </param>
        internal RunNotebookSnapshotResult(RunNotebookSnapshot snapshot, RunNotebookError error, string runId, string runStatus, string lastCheckedOn, string sessionId, string sparkPool)
        {
            Snapshot = snapshot;
            Error = error;
            RunId = runId;
            RunStatus = runStatus;
            LastCheckedOn = lastCheckedOn;
            SessionId = sessionId;
            SparkPool = sparkPool;
        }

        /// <summary> Run notebook snapshot. </summary>
        public RunNotebookSnapshot Snapshot { get; }
        /// <summary> Run notebook error. </summary>
        public RunNotebookError Error { get; }
        /// <summary> Run id. </summary>
        public string RunId { get; }
        /// <summary> Status of the run notebook. </summary>
        public string RunStatus { get; }
        /// <summary> Timestamp of last update. </summary>
        public string LastCheckedOn { get; }
        /// <summary> Livy session id. </summary>
        public string SessionId { get; }
        /// <summary> SparkPool name. </summary>
        public string SparkPool { get; }
    }
}
