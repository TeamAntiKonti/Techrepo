using System;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Models;
using WebFormsMvp;

namespace Techrepo.Web.Account.Views
{
    public interface IManageProfileView : IView<ManageProfileVIewModel>
    {
        event EventHandler<GetUserByIdEventArgs> OnUpdateProfile;
    }
}