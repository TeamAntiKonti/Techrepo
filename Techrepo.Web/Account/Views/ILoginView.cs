using System;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Models;
using WebFormsMvp;

namespace Techrepo.Web.Account.Views
{
    public interface ILoginView : IView<LoginViewModel>
    {
        event EventHandler<LoginEventArgs> OnLogin;
    }
}