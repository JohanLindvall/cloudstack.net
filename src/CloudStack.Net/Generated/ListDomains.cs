using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainsRequest : APIRequest
    {
        public ListDomainsRequest() : base("listDomains") {}

        /// <summary>
        /// List domain by domain ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// List domains by domain level.
        /// </summary>
        public int? Level {
            get { return (int?) Parameters[nameof(Level).ToLower()]; }
            set { Parameters[nameof(Level).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// List domain by domain name.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
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
    /// Lists domains and provides detailed information for listed domains
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomains(ListDomainsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomains(ListDomainsRequest request) => _proxy.Request<ListResponse<DomainResponse>>(request);
    }
}
