// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUsernameDownloadSettings : IUtf8JsonSerializable, IJsonModel<StorageCacheUsernameDownloadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheUsernameDownloadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheUsernameDownloadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsernameDownloadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUsernameDownloadSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EnableExtendedGroups.HasValue)
            {
                writer.WritePropertyName("extendedGroups"u8);
                writer.WriteBooleanValue(EnableExtendedGroups.Value);
            }
            if (UsernameSource.HasValue)
            {
                writer.WritePropertyName("usernameSource"u8);
                writer.WriteStringValue(UsernameSource.Value.ToString());
            }
            if (GroupFileUri != null)
            {
                writer.WritePropertyName("groupFileURI"u8);
                writer.WriteStringValue(GroupFileUri.AbsoluteUri);
            }
            if (UserFileUri != null)
            {
                writer.WritePropertyName("userFileURI"u8);
                writer.WriteStringValue(UserFileUri.AbsoluteUri);
            }
            if (LdapServer != null)
            {
                writer.WritePropertyName("ldapServer"u8);
                writer.WriteStringValue(LdapServer);
            }
            if (LdapBaseDN != null)
            {
                writer.WritePropertyName("ldapBaseDN"u8);
                writer.WriteStringValue(LdapBaseDN);
            }
            if (EncryptLdapConnection.HasValue)
            {
                writer.WritePropertyName("encryptLdapConnection"u8);
                writer.WriteBooleanValue(EncryptLdapConnection.Value);
            }
            if (RequireValidCertificate.HasValue)
            {
                writer.WritePropertyName("requireValidCertificate"u8);
                writer.WriteBooleanValue(RequireValidCertificate.Value);
            }
            if (AutoDownloadCertificate.HasValue)
            {
                writer.WritePropertyName("autoDownloadCertificate"u8);
                writer.WriteBooleanValue(AutoDownloadCertificate.Value);
            }
            if (CaCertificateUri != null)
            {
                writer.WritePropertyName("caCertificateURI"u8);
                writer.WriteStringValue(CaCertificateUri.AbsoluteUri);
            }
            if (options.Format != "W" && UsernameDownloaded.HasValue)
            {
                writer.WritePropertyName("usernameDownloaded"u8);
                writer.WriteStringValue(UsernameDownloaded.Value.ToString());
            }
            if (Credentials != null)
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
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

        StorageCacheUsernameDownloadSettings IJsonModel<StorageCacheUsernameDownloadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsernameDownloadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUsernameDownloadSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheUsernameDownloadSettings(document.RootElement, options);
        }

        internal static StorageCacheUsernameDownloadSettings DeserializeStorageCacheUsernameDownloadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? extendedGroups = default;
            StorageCacheUsernameSourceType? usernameSource = default;
            Uri groupFileUri = default;
            Uri userFileUri = default;
            string ldapServer = default;
            string ldapBaseDN = default;
            bool? encryptLdapConnection = default;
            bool? requireValidCertificate = default;
            bool? autoDownloadCertificate = default;
            Uri caCertificateUri = default;
            StorageCacheUsernameDownloadedType? usernameDownloaded = default;
            StorageCacheUsernameDownloadCredential credentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedGroups = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("usernameSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usernameSource = new StorageCacheUsernameSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groupFileURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupFileUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userFileURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userFileUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ldapServer"u8))
                {
                    ldapServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ldapBaseDN"u8))
                {
                    ldapBaseDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptLdapConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptLdapConnection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireValidCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireValidCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoDownloadCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoDownloadCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("caCertificateURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usernameDownloaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usernameDownloaded = new StorageCacheUsernameDownloadedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = StorageCacheUsernameDownloadCredential.DeserializeStorageCacheUsernameDownloadCredential(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheUsernameDownloadSettings(
                extendedGroups,
                usernameSource,
                groupFileUri,
                userFileUri,
                ldapServer,
                ldapBaseDN,
                encryptLdapConnection,
                requireValidCertificate,
                autoDownloadCertificate,
                caCertificateUri,
                usernameDownloaded,
                credentials,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheUsernameDownloadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsernameDownloadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUsernameDownloadSettings)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheUsernameDownloadSettings IPersistableModel<StorageCacheUsernameDownloadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsernameDownloadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheUsernameDownloadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUsernameDownloadSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheUsernameDownloadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
