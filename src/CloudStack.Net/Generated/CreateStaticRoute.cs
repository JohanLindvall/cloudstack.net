using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStaticRouteRequest : APIRequest
    {
        public CreateStaticRouteRequest() : base("createStaticRoute") {}

        /// <summary>
        /// static route cidr
        /// </summary>
        public string Cidr {
            get { return (string) Parameters[nameof(Cidr).ToLower()]; }
            set { Parameters[nameof(Cidr).ToLower()] = value; }
        }

        /// <summary>
        /// the gateway id we are creating static route for
        /// </summary>
        public Guid GatewayId {
            get { return (Guid) Parameters[nameof(GatewayId).ToLower()]; }
            set { Parameters[nameof(GatewayId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateStaticRoute(CreateStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateStaticRoute(CreateStaticRouteRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
