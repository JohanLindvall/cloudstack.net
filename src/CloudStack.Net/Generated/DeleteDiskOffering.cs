using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteDiskOfferingRequest : APIRequest
    {
        public DeleteDiskOfferingRequest() : base("deleteDiskOffering") {}

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteDiskOffering(DeleteDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteDiskOffering(DeleteDiskOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}