using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CopyIsoRequest : APIRequest
    {
        public CopyIsoRequest() : base("copyIso") {}

        /// <summary>
        /// Template ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// ID of the zone the template is being copied to.
        /// </summary>
        public Guid DestZoneId {
            get { return (Guid) Parameters[nameof(DestZoneId).ToLower()]; }
            set { Parameters[nameof(DestZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// ID of the zone the template is currently hosted on. If not specified and template is cross-zone, then we will sync this template to region wide image store.
        /// </summary>
        public Guid SourceZoneId {
            get { return (Guid) Parameters[nameof(SourceZoneId).ToLower()]; }
            set { Parameters[nameof(SourceZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Copies an iso from one zone to another.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CopyIso(CopyIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CopyIso(CopyIsoRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
