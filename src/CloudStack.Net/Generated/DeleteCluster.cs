using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteClusterRequest : APIRequest
    {
        public DeleteClusterRequest() : base("deleteCluster") {}

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a cluster.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCluster(DeleteClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCluster(DeleteClusterRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
