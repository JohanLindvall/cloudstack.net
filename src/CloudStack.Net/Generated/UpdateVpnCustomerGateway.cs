using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVpnCustomerGatewayRequest : APIRequest
    {
        public UpdateVpnCustomerGatewayRequest() : base("updateVpnCustomerGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// guest cidr of the customer gateway
        /// </summary>
        public string Cidrlist {
            get { return (string) Parameters[nameof(Cidrlist).ToLower()]; }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// ESP policy of the customer gateway
        /// </summary>
        public string EspPolicy {
            get { return (string) Parameters[nameof(EspPolicy).ToLower()]; }
            set { Parameters[nameof(EspPolicy).ToLower()] = value; }
        }

        /// <summary>
        /// public ip address id of the customer gateway
        /// </summary>
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// IKE policy of the customer gateway
        /// </summary>
        public string IkePolicy {
            get { return (string) Parameters[nameof(IkePolicy).ToLower()]; }
            set { Parameters[nameof(IkePolicy).ToLower()] = value; }
        }

        /// <summary>
        /// IPsec Preshared-Key of the customer gateway
        /// </summary>
        public string IpsecPsk {
            get { return (string) Parameters[nameof(IpsecPsk).ToLower()]; }
            set { Parameters[nameof(IpsecPsk).ToLower()] = value; }
        }

        /// <summary>
        /// the account associated with the gateway. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID associated with the gateway. If used with the account parameter returns the gateway associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// If DPD is enabled for VPN connection
        /// </summary>
        public bool? Dpd {
            get { return (bool?) Parameters[nameof(Dpd).ToLower()]; }
            set { Parameters[nameof(Dpd).ToLower()] = value; }
        }

        /// <summary>
        /// Lifetime of phase 2 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? EspLifetime {
            get { return (long?) Parameters[nameof(EspLifetime).ToLower()]; }
            set { Parameters[nameof(EspLifetime).ToLower()] = value; }
        }

        /// <summary>
        /// Force encapsulation for Nat Traversal
        /// </summary>
        public bool? Forceencap {
            get { return (bool?) Parameters[nameof(Forceencap).ToLower()]; }
            set { Parameters[nameof(Forceencap).ToLower()] = value; }
        }

        /// <summary>
        /// Lifetime of phase 1 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? IkeLifetime {
            get { return (long?) Parameters[nameof(IkeLifetime).ToLower()]; }
            set { Parameters[nameof(IkeLifetime).ToLower()] = value; }
        }

        /// <summary>
        /// name of this customer gateway
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Update site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVpnCustomerGateway(UpdateVpnCustomerGatewayRequest request);
        Task<AsyncJobResponse> UpdateVpnCustomerGatewayAsync(UpdateVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVpnCustomerGateway(UpdateVpnCustomerGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateVpnCustomerGatewayAsync(UpdateVpnCustomerGatewayRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
