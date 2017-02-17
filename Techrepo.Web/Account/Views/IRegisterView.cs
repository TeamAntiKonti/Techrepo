using System;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Models;
using WebFormsMvp;

namespace Techrepo.Web.Account.Views
{
    public interface IRegisterView : IView<RegisterViewModel>
    {
        event EventHandler<RegisterEventArgs> OnRegister;

        event EventHandler<SignInEventArgs> OnSignIn;
    }
}