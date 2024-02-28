// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherData : IUtf8JsonSerializable, IJsonModel<TrialMatcherData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrialMatcherData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrialMatcherData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("patients"u8);
            writer.WriteStartArray();
            foreach (var item in Patients)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Configuration != null)
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        TrialMatcherData IJsonModel<TrialMatcherData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrialMatcherData(document.RootElement, options);
        }

        internal static TrialMatcherData DeserializeTrialMatcherData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PatientRecord> patients = default;
            TrialMatcherModelConfiguration configuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<PatientRecord> array = new List<PatientRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientRecord.DeserializePatientRecord(item, options));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = TrialMatcherModelConfiguration.DeserializeTrialMatcherModelConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrialMatcherData(patients, configuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrialMatcherData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherData)} does not support '{options.Format}' format.");
            }
        }

        TrialMatcherData IPersistableModel<TrialMatcherData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrialMatcherData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrialMatcherData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherData(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
