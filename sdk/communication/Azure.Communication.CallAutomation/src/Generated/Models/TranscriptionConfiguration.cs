// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Configuration of live transcription. </summary>
    public partial class TranscriptionConfiguration
    {
        /// <summary> Initializes a new instance of TranscriptionConfiguration. </summary>
        /// <param name="transportUrl"> Transport URL for live transcription. </param>
        /// <param name="transportType"> The type of transport to be used for live transcription, eg. Websocket. </param>
        /// <param name="locale"> Defines the locale for the data e.g en-CA, en-AU. </param>
        /// <param name="startTranscription"> Determines if the transcription should be started immediately after call is answered or not. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transportUrl"/> or <paramref name="locale"/> is null. </exception>
        public TranscriptionConfiguration(string transportUrl, TranscriptionTransportType transportType, string locale, bool startTranscription)
        {
            Argument.AssertNotNull(transportUrl, nameof(transportUrl));
            Argument.AssertNotNull(locale, nameof(locale));

            TransportUrl = transportUrl;
            TransportType = transportType;
            Locale = locale;
            StartTranscription = startTranscription;
        }

        /// <summary> Transport URL for live transcription. </summary>
        public string TransportUrl { get; }
        /// <summary> The type of transport to be used for live transcription, eg. Websocket. </summary>
        public TranscriptionTransportType TransportType { get; }
        /// <summary> Defines the locale for the data e.g en-CA, en-AU. </summary>
        public string Locale { get; }
        /// <summary> Determines if the transcription should be started immediately after call is answered or not. </summary>
        public bool StartTranscription { get; }
    }
}
