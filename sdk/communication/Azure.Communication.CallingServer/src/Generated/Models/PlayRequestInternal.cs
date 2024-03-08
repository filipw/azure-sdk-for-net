// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The PlayRequest. </summary>
    internal partial class PlayRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="PlayRequestInternal"/>. </summary>
        /// <param name="playSourceInfo"> The source of the audio to be played. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="playSourceInfo"/> is null. </exception>
        public PlayRequestInternal(PlaySourceInternal playSourceInfo)
        {
            Argument.AssertNotNull(playSourceInfo, nameof(playSourceInfo));

            PlaySourceInfo = playSourceInfo;
            PlayTo = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="PlayRequestInternal"/>. </summary>
        /// <param name="playSourceInfo"> The source of the audio to be played. </param>
        /// <param name="playTo">
        /// The list of call participants play provided audio to.
        /// Plays to everyone in the call when not provided.
        /// </param>
        /// <param name="playOptions"> Defines options for playing the audio. </param>
        /// <param name="operationContext"> The value to identify context of the operation. </param>
        internal PlayRequestInternal(PlaySourceInternal playSourceInfo, IList<CommunicationIdentifierModel> playTo, PlayOptionsInternal playOptions, string operationContext)
        {
            PlaySourceInfo = playSourceInfo;
            PlayTo = playTo;
            PlayOptions = playOptions;
            OperationContext = operationContext;
        }

        /// <summary> The source of the audio to be played. </summary>
        public PlaySourceInternal PlaySourceInfo { get; }
        /// <summary> Defines options for playing the audio. </summary>
        public PlayOptionsInternal PlayOptions { get; set; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
