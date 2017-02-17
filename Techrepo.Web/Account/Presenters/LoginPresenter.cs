using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Views;
using WebFormsMvp;

namespace Techrepo.Web.Account.Presenters
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) 
            : base(view)
        {
            this.View.OnLogin += View_OnLogin;
        }

        private void View_OnLogin(object sender, LoginEventArgs e)
        {
            // Validate the user password
            var manager = e.Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signinManager = e.Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

            // This doen't count login failures towards account lockout
            // To enable password failures to trigger lockout, change to shouldLockout: true
            var result = signinManager.PasswordSignIn(e.UserName, e.Password, e.RememberMe, e.ShouldLockOut);

            this.View.Model.SignInStatus = result;
        }
    }
}