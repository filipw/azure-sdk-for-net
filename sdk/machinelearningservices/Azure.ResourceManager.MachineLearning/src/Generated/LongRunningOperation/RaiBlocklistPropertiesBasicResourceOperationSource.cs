// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class RaiBlocklistPropertiesBasicResourceOperationSource : IOperationSource<RaiBlocklistPropertiesBasicResource>
    {
        private readonly ArmClient _client;

        internal RaiBlocklistPropertiesBasicResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        RaiBlocklistPropertiesBasicResource IOperationSource<RaiBlocklistPropertiesBasicResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RaiBlocklistPropertiesBasicResourceData.DeserializeRaiBlocklistPropertiesBasicResourceData(document.RootElement);
            return new RaiBlocklistPropertiesBasicResource(_client, data);
        }

        async ValueTask<RaiBlocklistPropertiesBasicResource> IOperationSource<RaiBlocklistPropertiesBasicResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RaiBlocklistPropertiesBasicResourceData.DeserializeRaiBlocklistPropertiesBasicResourceData(document.RootElement);
            return new RaiBlocklistPropertiesBasicResource(_client, data);
        }
    }
}
