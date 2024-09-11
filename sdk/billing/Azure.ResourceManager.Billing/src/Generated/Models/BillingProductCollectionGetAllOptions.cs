// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The BillingProductCollectionGetAllOptions. </summary>
    public partial class BillingProductCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of <see cref="BillingProductCollectionGetAllOptions"/>. </summary>
        public BillingProductCollectionGetAllOptions()
        {
        }

        /// <summary> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </summary>
        [WirePath("filter")]
        public string Filter { get; set; }
        /// <summary> The orderby query option allows clients to request resources in a particular order. </summary>
        [WirePath("orderBy")]
        public string OrderBy { get; set; }
        /// <summary> The top query option requests the number of items in the queried collection to be included in the result. The maximum supported value for top is 50. </summary>
        [WirePath("top")]
        public long? Top { get; set; }
        /// <summary> The skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. </summary>
        [WirePath("skip")]
        public long? Skip { get; set; }
        /// <summary> The count query option allows clients to request a count of the matching resources included with the resources in the response. </summary>
        [WirePath("count")]
        public bool? Count { get; set; }
        /// <summary> The search query option allows clients to request items within a collection matching a free-text search expression. search is only supported for string fields. </summary>
        [WirePath("search")]
        public string Search { get; set; }
    }
}
