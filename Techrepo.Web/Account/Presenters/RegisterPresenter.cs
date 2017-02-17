using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Views;
using WebFormsMvp;

namespace Techrepo.Web.Account.Presenters
{
    public class RegisterPresenter : Presenter<IRegisterView>
    {
        public RegisterPresenter(IRegisterView view) 
            : base(view)
        {
            this.View.OnRegister += View_OnRegister;
            this.View.OnSignIn += View_OnSignIn;
        }

        private void View_OnSignIn(object sender, SignInEventArgs e)
        {
            var signInManager = e.Context.GetOwinContext().Get<ApplicationSignInManager>();

            signInManager.SignIn(e.User, isPersistent: false, rememberBrowser: false);            
        }

        private void View_OnRegister(object sender, RegisterEventArgs e)
        {
            var manager = e.Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = e.Context.GetOwinContext().Get<ApplicationSignInManager>();

            IdentityResult result = manager.Create(e.User, e.Password);

            if(result.Succeeded)
            {
                manager.AddToRole(e.User.Id, "Ordinary");
            }

            this.View.Model.IdentityResult = result;
        }
    }
}