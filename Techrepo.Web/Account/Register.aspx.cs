using System;
using System.Linq;
using Techrepo.Models;
using WebFormsMvp.Web;
using Techrepo.Web.Account.Models;
using Techrepo.Web.Account.Views;
using Techrepo.Web.Account.EventArguments;
using WebFormsMvp;
using Techrepo.Web.Account.Presenters;

namespace Techrepo.Web.Account
{
    [PresenterBinding(typeof(RegisterPresenter))]
    public partial class Register : MvpPage<RegisterViewModel>, IRegisterView
    {
        public event EventHandler<RegisterEventArgs> OnRegister;
        public event EventHandler<SignInEventArgs> OnSignIn;

        protected void CreateUser_Click(object sender, EventArgs e)
        {           
            var user = new User()
            {
                UserName = UserName.Text,
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Email = Email.Text
            };

            this.OnRegister?.Invoke(this, new RegisterEventArgs(this.Context, user, this.Password.Text));

            if (this.Model.IdentityResult.Succeeded)
            {                
                this.OnSignIn?.Invoke(this, new SignInEventArgs(this.Context, user));

                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = this.Model.IdentityResult.Errors.FirstOrDefault();
            }
        }
    }
}