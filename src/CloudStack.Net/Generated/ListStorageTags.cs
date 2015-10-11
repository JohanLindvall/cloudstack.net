using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageTagsRequest : APIRequest
    {
        public ListStorageTagsRequest() : base("listStorageTags") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists storage tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request) => _proxy.Request<ListResponse<StorageTagResponse>>(request);
    }
}
