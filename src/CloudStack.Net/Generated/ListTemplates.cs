using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplatesRequest : APIRequest
    {
        public ListTemplatesRequest() : base("listTemplates") {}

        /// <summary>
        /// possible values are "featured", "self", "selfexecutable","sharedexecutable","executable", and "community". * featured : templates that have been marked as featured and public. * self : templates that have been registered or created by the calling user. * selfexecutable : same as self, but only returns templates that can be used to deploy a new VM. * sharedexecutable : templates ready to be deployed that have been granted to the calling user by another user. * executable : templates that are owned by the calling user, or public templates, that can be used to deploy a VM. * community : templates that have been marked as public but not featured. * all : all templates (only usable by admins).
        /// </summary>
        public string TemplateFilter {
            get { return (string) Parameters[nameof(TemplateFilter).ToLower()]; }
            set { Parameters[nameof(TemplateFilter).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// the template name
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

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// show removed templates as well
        /// </summary>
        public bool? ShowRemoved {
            get { return (bool?) Parameters[nameof(ShowRemoved).ToLower()]; }
            set { Parameters[nameof(ShowRemoved).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags {
            get { return (IDictionary<string, string>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// list templates by zoneId
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List all public, private, and privileged templates.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request) => _proxy.Request<ListResponse<TemplateResponse>>(request);
    }
}
