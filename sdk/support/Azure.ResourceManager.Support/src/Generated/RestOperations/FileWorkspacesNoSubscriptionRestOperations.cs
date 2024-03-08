// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Support
{
    internal partial class FileWorkspacesNoSubscriptionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FileWorkspacesNoSubscriptionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FileWorkspacesNoSubscriptionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string fileWorkspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets details for a specific file workspace. </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FileWorkspaceDetailData>> GetAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateGetRequest(fileWorkspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileWorkspaceDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileWorkspaceDetailData.DeserializeFileWorkspaceDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FileWorkspaceDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets details for a specific file workspace. </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FileWorkspaceDetailData> Get(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateGetRequest(fileWorkspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileWorkspaceDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileWorkspaceDetailData.DeserializeFileWorkspaceDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FileWorkspaceDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string fileWorkspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a new file workspace. </summary>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FileWorkspaceDetailData>> CreateAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateCreateRequest(fileWorkspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        FileWorkspaceDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileWorkspaceDetailData.DeserializeFileWorkspaceDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new file workspace. </summary>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FileWorkspaceDetailData> Create(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateCreateRequest(fileWorkspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        FileWorkspaceDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileWorkspaceDetailData.DeserializeFileWorkspaceDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
