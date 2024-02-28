// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class KeyPhraseExtractionLROResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (TaskName != null)
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static KeyPhraseExtractionLROResult DeserializeKeyPhraseExtractionLROResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyPhraseResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            string taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = KeyPhraseResult.DeserializeKeyPhraseResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new KeyPhraseExtractionLROResult(lastUpdateDateTime, status, kind, taskName, results);
        }
    }
}
