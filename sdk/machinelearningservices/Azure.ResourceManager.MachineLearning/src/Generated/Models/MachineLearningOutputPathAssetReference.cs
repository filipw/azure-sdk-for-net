// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Reference to an asset via its path in a job output. </summary>
    public partial class MachineLearningOutputPathAssetReference : MachineLearningAssetReferenceBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningOutputPathAssetReference"/>. </summary>
        public MachineLearningOutputPathAssetReference()
        {
            ReferenceType = ReferenceType.OutputPath;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningOutputPathAssetReference"/>. </summary>
        /// <param name="referenceType"> [Required] Specifies the type of asset reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="jobId"> ARM resource ID of the job. </param>
        /// <param name="path"> The path of the file/directory in the job output. </param>
        internal MachineLearningOutputPathAssetReference(ReferenceType referenceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier jobId, string path) : base(referenceType, serializedAdditionalRawData)
        {
            JobId = jobId;
            Path = path;
            ReferenceType = referenceType;
        }

        /// <summary> ARM resource ID of the job. </summary>
        [WirePath("jobId")]
        public ResourceIdentifier JobId { get; set; }
        /// <summary> The path of the file/directory in the job output. </summary>
        [WirePath("path")]
        public string Path { get; set; }
    }
}
