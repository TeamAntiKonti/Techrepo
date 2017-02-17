using System;
using System.Web;
using Techrepo.Models;

namespace Techrepo.Web.Account.EventArguments
{
    public class SignInEventArgs : EventArgs
    {
        public SignInEventArgs(HttpContext context, User user)
        {
            this.Context = context;
            this.User = user;
        }

        public HttpContext Context { get; set; }
        public User User { get; set; }
    }
}