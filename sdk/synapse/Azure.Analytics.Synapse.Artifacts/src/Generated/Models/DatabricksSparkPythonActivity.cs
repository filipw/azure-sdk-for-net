// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> DatabricksSparkPython activity. </summary>
    public partial class DatabricksSparkPythonActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="DatabricksSparkPythonActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="pythonFile"/> is null. </exception>
        public DatabricksSparkPythonActivity(string name, object pythonFile) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(pythonFile, nameof(pythonFile));

            PythonFile = pythonFile;
            Parameters = new ChangeTrackingList<object>();
            Libraries = new ChangeTrackingList<IDictionary<string, object>>();
            Type = "DatabricksSparkPython";
        }

        /// <summary> Initializes a new instance of <see cref="DatabricksSparkPythonActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <param name="parameters"> Command line parameters that will be passed to the Python file. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksSparkPythonActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object pythonFile, IList<object> parameters, IList<IDictionary<string, object>> libraries) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            PythonFile = pythonFile;
            Parameters = parameters;
            Libraries = libraries;
            Type = type ?? "DatabricksSparkPython";
        }

        /// <summary> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </summary>
        public object PythonFile { get; set; }
        /// <summary> Command line parameters that will be passed to the Python file. </summary>
        public IList<object> Parameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, object>> Libraries { get; }
    }
}
