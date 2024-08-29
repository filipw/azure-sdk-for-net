// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningCustomModelJobOutput. </summary>
    public partial class MachineLearningCustomModelJobOutput : MachineLearningJobOutput
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCustomModelJobOutput"/>. </summary>
        public MachineLearningCustomModelJobOutput()
        {
            JobOutputType = JobOutputType.CustomModel;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCustomModelJobOutput"/>. </summary>
        /// <param name="description"> Description for the output. </param>
        /// <param name="jobOutputType"> [Required] Specifies the type of job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="mode"> Output Asset Delivery Mode. </param>
        /// <param name="uri"> Output Asset URI. </param>
        internal MachineLearningCustomModelJobOutput(string description, JobOutputType jobOutputType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningOutputDeliveryMode? mode, Uri uri) : base(description, jobOutputType, serializedAdditionalRawData)
        {
            Mode = mode;
            Uri = uri;
            JobOutputType = jobOutputType;
        }

        /// <summary> Output Asset Delivery Mode. </summary>
        public MachineLearningOutputDeliveryMode? Mode { get; set; }
        /// <summary> Output Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
