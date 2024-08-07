// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    internal partial class DialogConsentInternal
    {
        internal static DialogConsentInternal DeserializeDialogConsentInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            string operationContext = default;
            ResultInformation resultInformation = default;
            DialogInputType? dialogInputType = default;
            UserConsent userConsent = default;
            string dialogId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("dialogInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dialogInputType = new DialogInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userConsent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userConsent = UserConsent.DeserializeUserConsent(property.Value);
                    continue;
                }
                if (property.NameEquals("dialogId"u8))
                {
                    dialogId = property.Value.GetString();
                    continue;
                }
            }
            return new DialogConsentInternal(
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation,
                dialogInputType,
                userConsent,
                dialogId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DialogConsentInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDialogConsentInternal(document.RootElement);
        }
    }
}
