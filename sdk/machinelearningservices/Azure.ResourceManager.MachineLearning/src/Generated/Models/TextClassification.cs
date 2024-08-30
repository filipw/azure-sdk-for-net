// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Text Classification task in AutoML NLP vertical.
    /// NLP - Natural Language Processing.
    /// </summary>
    public partial class TextClassification : AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="TextClassification"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        public TextClassification(MachineLearningTableJobInput trainingData) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));

            TaskType = TaskType.TextClassification;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassification"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primaryMetric"> Primary metric for Text-Classification task. </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        internal TextClassification(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, IDictionary<string, BinaryData> serializedAdditionalRawData, ClassificationPrimaryMetric? primaryMetric, NlpVerticalFeaturizationSettings featurizationSettings, NlpVerticalLimitSettings limitSettings, MachineLearningTableJobInput validationData) : base(logVerbosity, targetColumnName, taskType, trainingData, serializedAdditionalRawData)
        {
            PrimaryMetric = primaryMetric;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            ValidationData = validationData;
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassification"/> for deserialization. </summary>
        internal TextClassification()
        {
        }

        /// <summary> Primary metric for Text-Classification task. </summary>
        [WirePath("primaryMetric")]
        public ClassificationPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        internal NlpVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Dataset language, useful for the text data. </summary>
        [WirePath("featurizationSettings.datasetLanguage")]
        public string FeaturizationDatasetLanguage
        {
            get => FeaturizationSettings is null ? default : FeaturizationSettings.DatasetLanguage;
            set
            {
                if (FeaturizationSettings is null)
                    FeaturizationSettings = new NlpVerticalFeaturizationSettings();
                FeaturizationSettings.DatasetLanguage = value;
            }
        }

        /// <summary> Execution constraints for AutoMLJob. </summary>
        [WirePath("limitSettings")]
        public NlpVerticalLimitSettings LimitSettings { get; set; }
        /// <summary> Validation data inputs. </summary>
        [WirePath("validationData")]
        public MachineLearningTableJobInput ValidationData { get; set; }
    }
}
