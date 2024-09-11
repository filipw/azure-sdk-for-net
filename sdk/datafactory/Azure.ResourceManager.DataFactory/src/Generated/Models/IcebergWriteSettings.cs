// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Iceberg write settings. </summary>
    public partial class IcebergWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="IcebergWriteSettings"/>. </summary>
        public IcebergWriteSettings()
        {
            FormatWriteSettingsType = "IcebergWriteSettings";
        }

        /// <summary> Initializes a new instance of <see cref="IcebergWriteSettings"/>. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IcebergWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(formatWriteSettingsType, additionalProperties)
        {
            FormatWriteSettingsType = formatWriteSettingsType ?? "IcebergWriteSettings";
        }
    }
}
