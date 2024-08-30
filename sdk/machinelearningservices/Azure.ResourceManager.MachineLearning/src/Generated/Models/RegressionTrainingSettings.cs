// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Regression Training related configuration. </summary>
    public partial class RegressionTrainingSettings : MachineLearningTrainingSettings
    {
        /// <summary> Initializes a new instance of <see cref="RegressionTrainingSettings"/>. </summary>
        public RegressionTrainingSettings()
        {
            AllowedTrainingAlgorithms = new ChangeTrackingList<AutoMLVerticalRegressionModel>();
            BlockedTrainingAlgorithms = new ChangeTrackingList<AutoMLVerticalRegressionModel>();
        }

        /// <summary> Initializes a new instance of <see cref="RegressionTrainingSettings"/>. </summary>
        /// <param name="isDnnTrainingEnabled"> Enable recommendation of DNN models. </param>
        /// <param name="isModelExplainabilityEnabled"> Flag to turn on explainability on best model. </param>
        /// <param name="isOnnxCompatibleModelsEnabled"> Flag for enabling onnx compatible models. </param>
        /// <param name="isStackEnsembleEnabled"> Enable stack ensemble run. </param>
        /// <param name="isVoteEnsembleEnabled"> Enable voting ensemble run. </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </param>
        /// <param name="stackEnsembleSettings"> Stack ensemble settings for stack ensemble run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="allowedTrainingAlgorithms"> Allowed models for regression task. </param>
        /// <param name="blockedTrainingAlgorithms"> Blocked models for regression task. </param>
        internal RegressionTrainingSettings(bool? isDnnTrainingEnabled, bool? isModelExplainabilityEnabled, bool? isOnnxCompatibleModelsEnabled, bool? isStackEnsembleEnabled, bool? isVoteEnsembleEnabled, TimeSpan? ensembleModelDownloadTimeout, MachineLearningStackEnsembleSettings stackEnsembleSettings, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<AutoMLVerticalRegressionModel> allowedTrainingAlgorithms, IList<AutoMLVerticalRegressionModel> blockedTrainingAlgorithms) : base(isDnnTrainingEnabled, isModelExplainabilityEnabled, isOnnxCompatibleModelsEnabled, isStackEnsembleEnabled, isVoteEnsembleEnabled, ensembleModelDownloadTimeout, stackEnsembleSettings, serializedAdditionalRawData)
        {
            AllowedTrainingAlgorithms = allowedTrainingAlgorithms;
            BlockedTrainingAlgorithms = blockedTrainingAlgorithms;
        }

        /// <summary> Allowed models for regression task. </summary>
        [WirePath("allowedTrainingAlgorithms")]
        public IList<AutoMLVerticalRegressionModel> AllowedTrainingAlgorithms { get; set; }
        /// <summary> Blocked models for regression task. </summary>
        [WirePath("blockedTrainingAlgorithms")]
        public IList<AutoMLVerticalRegressionModel> BlockedTrainingAlgorithms { get; set; }
    }
}
