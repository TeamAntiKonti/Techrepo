using System;
using System.Web;

namespace Techrepo.Web.Account.EventArguments
{
    public class GetUserByIdEventArgs : EventArgs
    {
        public GetUserByIdEventArgs(HttpContext context, string id, string path)
        {
            this.Id = id;
            this.Path = path;
            this.Context = context;
        }

        public string Path { get; set; }
        public string Id { get; set; }
        public HttpContext Context { get; set; }
    }
}