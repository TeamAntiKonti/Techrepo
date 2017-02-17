using System;
using System.Web;
using Techrepo.Models;

namespace Techrepo.Web.Account.EventArguments
{
    public class RegisterEventArgs : EventArgs
    {
        public RegisterEventArgs(HttpContext context, User user, string password)
        {
            this.Context = context;
            this.User = user;
            this.Password = password;
        }

        public HttpContext Context { get; set; }
        public User User { get; set; }
        public string Password { get; set; }
    }
}