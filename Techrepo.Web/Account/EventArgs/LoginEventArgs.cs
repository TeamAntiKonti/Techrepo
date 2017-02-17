using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Techrepo.Web.Account.EventArguments
{
    public class LoginEventArgs : EventArgs
    {
        public LoginEventArgs(HttpContext context, string userName, string password, bool rememberMe, bool shouldLockOut)
        {
            this.Context = context;
            this.UserName = userName;
            this.Password = password;
            this.RememberMe = rememberMe;
            this.ShouldLockOut = shouldLockOut;   
        }

        public HttpContext Context { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public bool ShouldLockOut { get; set; }
    }
}