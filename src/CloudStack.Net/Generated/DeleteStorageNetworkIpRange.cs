using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStorageNetworkIpRangeRequest : APIRequest
    {
        public DeleteStorageNetworkIpRangeRequest() : base("deleteStorageNetworkIpRange") {}

        /// <summary>
        /// the uuid of the storage network ip range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a storage network IP Range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteStorageNetworkIpRange(DeleteStorageNetworkIpRangeRequest request);
        Task<AsyncJobResponse> DeleteStorageNetworkIpRangeAsync(DeleteStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteStorageNetworkIpRange(DeleteStorageNetworkIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteStorageNetworkIpRangeAsync(DeleteStorageNetworkIpRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
