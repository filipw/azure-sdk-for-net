// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents
{
    internal partial class IndexersRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly Guid? _xMsClientRequestId;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of IndexersRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public IndexersRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, Guid? xMsClientRequestId = null, string apiVersion = "2024-07-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _xMsClientRequestId = xMsClientRequestId;
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateResetRequest(string indexerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')/search.reset", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Resets the change tracking state associated with an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public async Task<Response> ResetAsync(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateResetRequest(indexerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Resets the change tracking state associated with an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public Response Reset(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateResetRequest(indexerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRunRequest(string indexerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')/search.run", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Runs an indexer on-demand. </summary>
        /// <param name="indexerName"> The name of the indexer to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public async Task<Response> RunAsync(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateRunRequest(indexerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Runs an indexer on-demand. </summary>
        /// <param name="indexerName"> The name of the indexer to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public Response Run(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateRunRequest(indexerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string indexerName, SearchIndexer indexer, string ifMatch, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(indexer);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new indexer or updates an indexer if it already exists. </summary>
        /// <param name="indexerName"> The name of the indexer to create or update. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> or <paramref name="indexer"/> is null. </exception>
        public async Task<Response<SearchIndexer>> CreateOrUpdateAsync(string indexerName, SearchIndexer indexer, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }
            if (indexer == null)
            {
                throw new ArgumentNullException(nameof(indexer));
            }

            using var message = CreateCreateOrUpdateRequest(indexerName, indexer, ifMatch, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndexer value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new indexer or updates an indexer if it already exists. </summary>
        /// <param name="indexerName"> The name of the indexer to create or update. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> or <paramref name="indexer"/> is null. </exception>
        public Response<SearchIndexer> CreateOrUpdate(string indexerName, SearchIndexer indexer, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }
            if (indexer == null)
            {
                throw new ArgumentNullException(nameof(indexer));
            }

            using var message = CreateCreateOrUpdateRequest(indexerName, indexer, ifMatch, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndexer value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string indexerName, string ifMatch, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Deletes an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string indexerName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateDeleteRequest(indexerName, ifMatch, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public Response Delete(string indexerName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateDeleteRequest(indexerName, ifMatch, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string indexerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Retrieves an indexer definition. </summary>
        /// <param name="indexerName"> The name of the indexer to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public async Task<Response<SearchIndexer>> GetAsync(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateGetRequest(indexerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexer value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves an indexer definition. </summary>
        /// <param name="indexerName"> The name of the indexer to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public Response<SearchIndexer> Get(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateGetRequest(indexerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexer value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string select)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Lists all indexers available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the indexers to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListIndexersResult>> ListAsync(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListIndexersResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListIndexersResult.DeserializeListIndexersResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all indexers available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the indexers to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListIndexersResult> List(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListIndexersResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListIndexersResult.DeserializeListIndexersResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(SearchIndexer indexer)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(indexer);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new indexer. </summary>
        /// <param name="indexer"> The definition of the indexer to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexer"/> is null. </exception>
        public async Task<Response<SearchIndexer>> CreateAsync(SearchIndexer indexer, CancellationToken cancellationToken = default)
        {
            if (indexer == null)
            {
                throw new ArgumentNullException(nameof(indexer));
            }

            using var message = CreateCreateRequest(indexer);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndexer value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new indexer. </summary>
        /// <param name="indexer"> The definition of the indexer to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexer"/> is null. </exception>
        public Response<SearchIndexer> Create(SearchIndexer indexer, CancellationToken cancellationToken = default)
        {
            if (indexer == null)
            {
                throw new ArgumentNullException(nameof(indexer));
            }

            using var message = CreateCreateRequest(indexer);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndexer value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexer.DeserializeSearchIndexer(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStatusRequest(string indexerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexers('", false);
            uri.AppendPath(indexerName, true);
            uri.AppendPath("')/search.status", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Returns the current status and execution history of an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer for which to retrieve status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public async Task<Response<SearchIndexerStatus>> GetStatusAsync(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateGetStatusRequest(indexerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexerStatus value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexerStatus.DeserializeSearchIndexerStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the current status and execution history of an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer for which to retrieve status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexerName"/> is null. </exception>
        public Response<SearchIndexerStatus> GetStatus(string indexerName, CancellationToken cancellationToken = default)
        {
            if (indexerName == null)
            {
                throw new ArgumentNullException(nameof(indexerName));
            }

            using var message = CreateGetStatusRequest(indexerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexerStatus value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexerStatus.DeserializeSearchIndexerStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
