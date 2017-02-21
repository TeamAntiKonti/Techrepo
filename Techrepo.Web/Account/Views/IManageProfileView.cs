using System;
using System.Web;
using System.Web.ModelBinding;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Models;
using WebFormsMvp;

namespace Techrepo.Web.Account.Views
{
    public interface IManageProfileView : IView<ManageProfileVIewModel>
    {
        event EventHandler<GetUserByIdEventArgs> OnUpdateProfile;
        event EventHandler<GetUserByIdEventArgs> OnGetUserDetails;
        event EventHandler<UserDetailsEventArgs> OnUpdateUserInfo;

        HttpResponse Response { get; }

        ModelStateDictionary ModelState { get; }

        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}