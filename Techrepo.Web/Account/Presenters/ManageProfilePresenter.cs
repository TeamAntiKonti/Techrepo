using System;
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
            this.View.OnUpdateProfile += View_OnUpdateProfile;     
        }

        private void View_OnUpdateProfile(object sender, GetUserByIdEventArgs e)
        {
            userService.UpdateAvatarByUserId(e.Id, e.Path);            
        }
    }
}