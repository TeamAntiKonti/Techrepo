using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Techrepo.Web.Account.Models
{
    public class LoginViewModel 
    {
        public SignInStatus SignInStatus { get; set; }
    }
}