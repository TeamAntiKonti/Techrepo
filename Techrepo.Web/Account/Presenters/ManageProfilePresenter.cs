using System;
using Techrepo.Models;
using Techrepo.Services;
using Techrepo.Web.Account.EventArguments;
using Techrepo.Web.Account.Views;
using WebFormsMvp;

namespace Techrepo.Web.Account.Presenters
{
    public class ManageProfilePresenter : Presenter<IManageProfileView>
    {
        private IUserService userService;
        public ManageProfilePresenter(IManageProfileView view, IUserService userService) 
            : base(view)
        {
            this.userService = userService;
            //this.View.OnUpdateProfile += View_OnUpdateProfile;
            this.View.OnGetUserDetails += View_OnGetUserDetails;
            this.View.OnUpdateUserInfo += View_OnUpdateUserInfo;
        }

        private void View_OnUpdateUserInfo(object sender, UserDetailsEventArgs e)
        {            
            var u = this.userService.GetUserById(e.Id);

            this.View.TryUpdateModel(u);

            this.userService.UpdateUserInfo(e.User, e.Id);
        }

        private void View_OnGetUserDetails(object sender, GetUserByIdEventArgs e)
        {            
            this.View.Model.User = this.userService.GetUserById(e.Id);
        }

        // Legacy
        //private void View_OnUpdateProfile(object sender, GetUserByIdEventArgs e)
        //{
        //    userService.UpdateAvatarByUserId(e.Id, e.Path);            
        //}
    }
}