using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnCustomerGatewayRequest : APIRequest
    {
        public CreateVpnCustomerGatewayRequest() : base("createVpnCustomerGateway") {}

        /// <summary>
        /// guest cidr list of the customer gateway
        /// </summary>
        public string PeerCidrList { get; set; }

        /// <summary>
        /// ESP policy of the customer gateway
        /// </summary>
        public string EspPolicy { get; set; }

        /// <summary>
        /// public ip address id of the customer gateway
        /// </summary>
        public string GatewayIp { get; set; }

        /// <summary>
        /// IKE policy of the customer gateway
        /// </summary>
        public string IkePolicy { get; set; }

        /// <summary>
        /// IPsec Preshared-Key of the customer gateway
        /// </summary>
        public string IpsecPsk { get; set; }

        /// <summary>
        /// the account associated with the gateway. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID associated with the gateway. If used with the account parameter returns the gateway associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// If DPD is enabled for VPN connection
        /// </summary>
        public bool? Dpd { get; set; }

        /// <summary>
        /// Lifetime of phase 2 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? EspLifetime { get; set; }

        /// <summary>
        /// Lifetime of phase 1 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? IkeLifetime { get; set; }

        /// <summary>
        /// name of this customer gateway
        /// </summary>
        public string Name { get; set; }

    }
    /// <summary>
    /// Creates site to site vpn customer gateway
    /// </summary>
    /// <summary>
    /// Creates site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteCustomerGatewayResponse CreateVpnCustomerGateway(CreateVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteCustomerGatewayResponse CreateVpnCustomerGateway(CreateVpnCustomerGatewayRequest request) => _proxy.Request<Site2SiteCustomerGatewayResponse>(request);
    }
}