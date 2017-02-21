using System;
using System.Web;

namespace Techrepo.Web.Account.EventArguments
{
    public class GetUserByIdEventArgs : EventArgs
    {
        public GetUserByIdEventArgs(string id)
        {
            this.Id = id;
        }
        public string Id { get; set; }
    }
}