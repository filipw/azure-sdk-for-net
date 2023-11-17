// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Document analysis parameters. </summary>
    public partial class AnalyzeDocumentContent
    {
        /// <summary> Initializes a new instance of AnalyzeDocumentContent. </summary>
        public AnalyzeDocumentContent()
        {
        }

        /// <summary> Initializes a new instance of AnalyzeDocumentContent. </summary>
        /// <param name="urlSource"> Document URL to analyze.  Either urlSource or base64Source must be specified. </param>
        /// <param name="base64Source">
        /// Base64 encoding of the document to analyze.  Either urlSource or base64Source
        /// must be specified.
        /// </param>
        internal AnalyzeDocumentContent(Uri urlSource, BinaryData base64Source)
        {
            UrlSource = urlSource;
            Base64Source = base64Source;
        }

        /// <summary> Document URL to analyze.  Either urlSource or base64Source must be specified. </summary>
        public Uri UrlSource { get; set; }
        /// <summary>
        /// Base64 encoding of the document to analyze.  Either urlSource or base64Source
        /// must be specified.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Base64Source { get; set; }
    }
}
