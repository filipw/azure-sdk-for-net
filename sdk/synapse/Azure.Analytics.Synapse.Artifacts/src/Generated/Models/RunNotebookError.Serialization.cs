// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookErrorConverter))]
    public partial class RunNotebookError
    {
        internal static RunNotebookError DeserializeRunNotebookError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ename = default;
            string evalue = default;
            IReadOnlyList<string> traceback = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ename"u8))
                {
                    ename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evalue"u8))
                {
                    evalue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("traceback"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    traceback = array;
                    continue;
                }
            }
            return new RunNotebookError(ename, evalue, traceback ?? new ChangeTrackingList<string>());
        }

        internal partial class RunNotebookErrorConverter : JsonConverter<RunNotebookError>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookError model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RunNotebookError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookError(document.RootElement);
            }
        }
    }
}
