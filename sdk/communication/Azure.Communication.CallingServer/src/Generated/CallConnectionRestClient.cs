// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    internal partial class CallConnectionRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of CallConnectionRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CallConnectionRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-06-15-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateCallRequest(IEnumerable<CommunicationIdentifierModel> targets, CommunicationIdentifierModel source, string callbackUri, PhoneNumberIdentifierModel alternateCallerId, string subject, IEnumerable<CallModality> requestedMediaTypes, IEnumerable<EventSubscriptionType> requestedCallEvents)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            CreateCallRequestInternal createCallRequestInternal = new CreateCallRequestInternal(targets.ToList(), source, callbackUri)
            {
                AlternateCallerId = alternateCallerId,
                Subject = subject
            };
            if (requestedMediaTypes != null)
            {
                foreach (var value in requestedMediaTypes)
                {
                    createCallRequestInternal.RequestedMediaTypes.Add(value);
                }
            }
            if (requestedCallEvents != null)
            {
                foreach (var value in requestedCallEvents)
                {
                    createCallRequestInternal.RequestedCallEvents.Add(value);
                }
            }
            var model = createCallRequestInternal;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Create a new call. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="alternateCallerId"> The alternate identity of the source of the call if dialing out to a pstn number. </param>
        /// <param name="subject"> The subject. </param>
        /// <param name="requestedMediaTypes"> The requested modalities. </param>
        /// <param name="requestedCallEvents"> The requested call events to subscribe to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/>, <paramref name="source"/>, or <paramref name="callbackUri"/> is null. </exception>
        public async Task<Response<CreateCallResponse>> CreateCallAsync(IEnumerable<CommunicationIdentifierModel> targets, CommunicationIdentifierModel source, string callbackUri, PhoneNumberIdentifierModel alternateCallerId = null, string subject = null, IEnumerable<CallModality> requestedMediaTypes = null, IEnumerable<EventSubscriptionType> requestedCallEvents = null, CancellationToken cancellationToken = default)
        {
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            using var message = CreateCreateCallRequest(targets, source, callbackUri, alternateCallerId, subject, requestedMediaTypes, requestedCallEvents);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CreateCallResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CreateCallResponse.DeserializeCreateCallResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a new call. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="alternateCallerId"> The alternate identity of the source of the call if dialing out to a pstn number. </param>
        /// <param name="subject"> The subject. </param>
        /// <param name="requestedMediaTypes"> The requested modalities. </param>
        /// <param name="requestedCallEvents"> The requested call events to subscribe to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/>, <paramref name="source"/>, or <paramref name="callbackUri"/> is null. </exception>
        public Response<CreateCallResponse> CreateCall(IEnumerable<CommunicationIdentifierModel> targets, CommunicationIdentifierModel source, string callbackUri, PhoneNumberIdentifierModel alternateCallerId = null, string subject = null, IEnumerable<CallModality> requestedMediaTypes = null, IEnumerable<EventSubscriptionType> requestedCallEvents = null, CancellationToken cancellationToken = default)
        {
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            using var message = CreateCreateCallRequest(targets, source, callbackUri, alternateCallerId, subject, requestedMediaTypes, requestedCallEvents);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CreateCallResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CreateCallResponse.DeserializeCreateCallResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateHangupCallRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/:hangup", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Hangup a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> HangupCallAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateHangupCallRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Hangup a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response HangupCall(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateHangupCallRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteCallRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> DeleteCallAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateDeleteCallRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response DeleteCall(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateDeleteCallRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePlayAudioRequest(string callConnectionId, string audioFileUri, bool? loop, string operationContext, string audioFileId, string callbackUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/:playAudio", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new PlayAudioRequest()
            {
                AudioFileUri = audioFileUri,
                Loop = loop,
                OperationContext = operationContext,
                AudioFileId = audioFileId,
                CallbackUri = callbackUri
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Play audio in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="audioFileUri">
        /// The media resource uri of the play audio request.
        /// 
        /// Currently only Wave file (.wav) format audio prompts are supported.
        /// 
        /// More specifically, the audio content in the wave file must be mono (single-channel),
        /// 
        /// 16-bit samples with a 16,000 (16KHz) sampling rate.
        /// </param>
        /// <param name="loop"> The flag indicating whether audio file needs to be played in loop or not. </param>
        /// <param name="operationContext"> The value to identify context of the operation. </param>
        /// <param name="audioFileId"> An id for the media in the AudioFileUri, using which we cache the media resource. </param>
        /// <param name="callbackUri"> The callback Uri to receive PlayAudio status notifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response<PlayAudioResponse>> PlayAudioAsync(string callConnectionId, string audioFileUri = null, bool? loop = null, string operationContext = null, string audioFileId = null, string callbackUri = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreatePlayAudioRequest(callConnectionId, audioFileUri, loop, operationContext, audioFileId, callbackUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        PlayAudioResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PlayAudioResponse.DeserializePlayAudioResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Play audio in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="audioFileUri">
        /// The media resource uri of the play audio request.
        /// 
        /// Currently only Wave file (.wav) format audio prompts are supported.
        /// 
        /// More specifically, the audio content in the wave file must be mono (single-channel),
        /// 
        /// 16-bit samples with a 16,000 (16KHz) sampling rate.
        /// </param>
        /// <param name="loop"> The flag indicating whether audio file needs to be played in loop or not. </param>
        /// <param name="operationContext"> The value to identify context of the operation. </param>
        /// <param name="audioFileId"> An id for the media in the AudioFileUri, using which we cache the media resource. </param>
        /// <param name="callbackUri"> The callback Uri to receive PlayAudio status notifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response<PlayAudioResponse> PlayAudio(string callConnectionId, string audioFileUri = null, bool? loop = null, string operationContext = null, string audioFileId = null, string callbackUri = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreatePlayAudioRequest(callConnectionId, audioFileUri, loop, operationContext, audioFileId, callbackUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        PlayAudioResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PlayAudioResponse.DeserializePlayAudioResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelAllMediaOperationsRequest(string callConnectionId, string operationContext)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/:cancelAllMediaOperations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new CancelAllMediaOperationsRequest()
            {
                OperationContext = operationContext
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Cancel all media operations. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="operationContext"> The context for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response<CancelAllMediaOperationsResponse>> CancelAllMediaOperationsAsync(string callConnectionId, string operationContext = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId, operationContext);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CancelAllMediaOperationsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CancelAllMediaOperationsResponse.DeserializeCancelAllMediaOperationsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancel all media operations. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="operationContext"> The context for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response<CancelAllMediaOperationsResponse> CancelAllMediaOperations(string callConnectionId, string operationContext = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId, operationContext);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CancelAllMediaOperationsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CancelAllMediaOperationsResponse.DeserializeCancelAllMediaOperationsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateInviteParticipantsRequest(string callConnectionId, IEnumerable<CommunicationIdentifierModel> participants, PhoneNumberIdentifierModel alternateCallerId, string operationContext, string callbackUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new InviteParticipantsRequestInternal(participants.ToList())
            {
                AlternateCallerId = alternateCallerId,
                OperationContext = operationContext,
                CallbackUri = callbackUri
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Invite participants to the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="participants"> The list of participants to be added to the call. </param>
        /// <param name="alternateCallerId"> The alternate identity of source participant. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participants"/> is null. </exception>
        public async Task<Response> InviteParticipantsAsync(string callConnectionId, IEnumerable<CommunicationIdentifierModel> participants, PhoneNumberIdentifierModel alternateCallerId = null, string operationContext = null, string callbackUri = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateInviteParticipantsRequest(callConnectionId, participants, alternateCallerId, operationContext, callbackUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Invite participants to the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="participants"> The list of participants to be added to the call. </param>
        /// <param name="alternateCallerId"> The alternate identity of source participant. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participants"/> is null. </exception>
        public Response InviteParticipants(string callConnectionId, IEnumerable<CommunicationIdentifierModel> participants, PhoneNumberIdentifierModel alternateCallerId = null, string operationContext = null, string callbackUri = null, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateInviteParticipantsRequest(callConnectionId, participants, alternateCallerId, operationContext, callbackUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveParticipantRequest(string callConnectionId, string participantId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants/", false);
            uri.AppendPath(participantId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Remove participant from the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participantId"/> is null. </exception>
        public async Task<Response> RemoveParticipantAsync(string callConnectionId, string participantId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participantId == null)
            {
                throw new ArgumentNullException(nameof(participantId));
            }

            using var message = CreateRemoveParticipantRequest(callConnectionId, participantId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Remove participant from the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participantId"/> is null. </exception>
        public Response RemoveParticipant(string callConnectionId, string participantId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participantId == null)
            {
                throw new ArgumentNullException(nameof(participantId));
            }

            using var message = CreateRemoveParticipantRequest(callConnectionId, participantId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
