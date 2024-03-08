// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A site for the Webchat channel. </summary>
    public partial class WebChatSite : BotChannelSite
    {
        /// <summary> Initializes a new instance of <see cref="WebChatSite"/>. </summary>
        /// <param name="siteName"> Site name. </param>
        /// <param name="isEnabled"> Whether this site is enabled for DirectLine channel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public WebChatSite(string siteName, bool isEnabled) : base(siteName, isEnabled)
        {
            Argument.AssertNotNull(siteName, nameof(siteName));
        }

        /// <summary> Initializes a new instance of <see cref="WebChatSite"/>. </summary>
        /// <param name="tenantId"> Tenant Id. </param>
        /// <param name="siteId"> Site Id. </param>
        /// <param name="siteName"> Site name. </param>
        /// <param name="key"> Primary key. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="key2"> Secondary key. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="isEnabled"> Whether this site is enabled for DirectLine channel. </param>
        /// <param name="isTokenEnabled"> Whether this site is token enabled for channel. </param>
        /// <param name="isEndpointParametersEnabled"> Whether this site is EndpointParameters enabled for channel. </param>
        /// <param name="isDetailedLoggingEnabled"> Whether this site is disabled detailed logging for. </param>
        /// <param name="isBlockUserUploadEnabled"> Whether this site is enabled for block user upload. </param>
        /// <param name="isNoStorageEnabled"> Whether this no-storage site is disabled detailed logging for. </param>
        /// <param name="etag"> Entity Tag. </param>
        /// <param name="appId"> DirectLine application id. </param>
        /// <param name="isV1Enabled"> Whether this site is enabled for Bot Framework V1 protocol. </param>
        /// <param name="isV3Enabled"> Whether this site is enabled for Bot Framework V3 protocol. </param>
        /// <param name="isSecureSiteEnabled"> Whether this site is enabled for authentication with Bot Framework. </param>
        /// <param name="trustedOrigins"> List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True. </param>
        /// <param name="isWebChatSpeechEnabled"> Whether this site is enabled for Webchat Speech. </param>
        /// <param name="isWebchatPreviewEnabled"> Whether this site is enabled for preview versions of Webchat. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebChatSite(Guid? tenantId, string siteId, string siteName, string key, string key2, bool isEnabled, bool? isTokenEnabled, bool? isEndpointParametersEnabled, bool? isDetailedLoggingEnabled, bool? isBlockUserUploadEnabled, bool? isNoStorageEnabled, ETag? etag, string appId, bool? isV1Enabled, bool? isV3Enabled, bool? isSecureSiteEnabled, IList<string> trustedOrigins, bool? isWebChatSpeechEnabled, bool? isWebchatPreviewEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(tenantId, siteId, siteName, key, key2, isEnabled, isTokenEnabled, isEndpointParametersEnabled, isDetailedLoggingEnabled, isBlockUserUploadEnabled, isNoStorageEnabled, etag, appId, isV1Enabled, isV3Enabled, isSecureSiteEnabled, trustedOrigins, isWebChatSpeechEnabled, isWebchatPreviewEnabled, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebChatSite"/> for deserialization. </summary>
        internal WebChatSite()
        {
        }
    }
}
