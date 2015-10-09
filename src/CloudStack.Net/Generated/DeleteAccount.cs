using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAccountRequest : APIRequest
    {
        public DeleteAccountRequest() : base("deleteAccount") {}

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a account, and all users associated with this account
    /// </summary>
    /// <summary>
    /// Deletes a account, and all users associated with this account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAccount(DeleteAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAccount(DeleteAccountRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}