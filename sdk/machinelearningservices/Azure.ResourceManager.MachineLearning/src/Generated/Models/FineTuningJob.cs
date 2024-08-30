// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> FineTuning Job definition. </summary>
    public partial class FineTuningJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/>. </summary>
        /// <param name="fineTuningDetails">
        /// [Required]
        /// Please note <see cref="FineTuningVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAiFineTuning"/> and <see cref="CustomModelFineTuning"/>.
        /// </param>
        /// <param name="outputs">
        /// [Required]
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningDetails"/> or <paramref name="outputs"/> is null. </exception>
        public FineTuningJob(FineTuningVertical fineTuningDetails, IDictionary<string, MachineLearningJobOutput> outputs)
        {
            Argument.AssertNotNull(fineTuningDetails, nameof(fineTuningDetails));
            Argument.AssertNotNull(outputs, nameof(outputs));

            FineTuningDetails = fineTuningDetails;
            Outputs = outputs;
            JobType = JobType.FineTuning;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="fineTuningDetails">
        /// [Required]
        /// Please note <see cref="FineTuningVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAiFineTuning"/> and <see cref="CustomModelFineTuning"/>.
        /// </param>
        /// <param name="resources"> Instance types and other resources for the job. </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="outputs">
        /// [Required]
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        internal FineTuningJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, FineTuningVertical fineTuningDetails, JobResources resources, JobQueueSettings queueSettings, IDictionary<string, MachineLearningJobOutput> outputs) : base(description, properties, tags, serializedAdditionalRawData, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, services, status)
        {
            FineTuningDetails = fineTuningDetails;
            Resources = resources;
            QueueSettings = queueSettings;
            Outputs = outputs;
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJob"/> for deserialization. </summary>
        internal FineTuningJob()
        {
        }

        /// <summary>
        /// [Required]
        /// Please note <see cref="FineTuningVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAiFineTuning"/> and <see cref="CustomModelFineTuning"/>.
        /// </summary>
        [WirePath("fineTuningDetails")]
        public FineTuningVertical FineTuningDetails { get; set; }
        /// <summary> Instance types and other resources for the job. </summary>
        internal JobResources Resources { get; set; }
        /// <summary> List of instance types to choose from. </summary>
        [WirePath("resources.instanceTypes")]
        public IList<string> ResourcesInstanceTypes
        {
            get
            {
                if (Resources is null)
                    Resources = new JobResources();
                return Resources.InstanceTypes;
            }
        }

        /// <summary> Queue settings for the job. </summary>
        internal JobQueueSettings QueueSettings { get; set; }
        /// <summary> Controls the compute job tier. </summary>
        [WirePath("queueSettings.jobTier")]
        public JobTier? QueueJobTier
        {
            get => QueueSettings is null ? default : QueueSettings.JobTier;
            set
            {
                if (QueueSettings is null)
                    QueueSettings = new JobQueueSettings();
                QueueSettings.JobTier = value;
            }
        }

        /// <summary>
        /// [Required]
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        [WirePath("outputs")]
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; }
    }
}
