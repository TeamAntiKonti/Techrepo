using System;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using WebFormsMvp.Web;
using Techrepo.Web.Account.Models;
using Techrepo.Web.Account.Views;
using WebFormsMvp;
using Techrepo.Web.Account.Presenters;
using Techrepo.Web.Account.EventArguments;
using System.IO;
using Techrepo.Models;

namespace Techrepo.Web.Account
{
    [PresenterBinding(typeof(ManageProfilePresenter))]
    public partial class Manage : MvpPage<ManageProfileVIewModel>, IManageProfileView
    {
        public readonly string defaultAvatar = "http://static.baubau.bg/thumbs/12/neverni-mitove-za-kotkite.jpg";

        protected string SuccessMessage
        {
            get;
            private set;
        }

        public event EventHandler<GetUserByIdEventArgs> OnUpdateProfile;
        public event EventHandler<GetUserByIdEventArgs> OnGetUserDetails;
        public event EventHandler<UserDetailsEventArgs> OnUpdateUserInfo;

        public string AvatarUrl { get; set; }

        private bool HasPassword(ApplicationUserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        public User GetUserInfo()
        {            
            // returns the User Item in the FormView
            string userId = this.Context.User.Identity.GetUserId();
            this.OnGetUserDetails?.Invoke(this, new GetUserByIdEventArgs(userId));

            return this.Model.User;
        }

        public void Page_Load()
        {
            // fills the users data
            string userId = this.Context.User.Identity.GetUserId();
            this.OnGetUserDetails?.Invoke(this, new GetUserByIdEventArgs(userId));
        }



        //protected void Page_Load()
        //{
        //    string userId = this.Context.User.Identity.GetUserId();

        //    this.OnGetUserDetails?.Invoke(this, new GetUserByIdEventArgs(this.Context, userId, ""));

        //    this.FirstName.Text = this.Model.User.FirstName;
        //    this.LastName.Text = this.Model.User.LastName;

        //    string filename = userId + ".png";
        //    string directoryOfPhoto = "~/images/" + filename;

        //    if(this.AvatarUrl == null)
        //    {
        //        this.AvatarUrl = defaultAvatar;
        //    }
        //    else
        //    {
        //        this.AvatarUrl = directoryOfPhoto;
        //    }

        //    var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();

        //    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

        //    if (!IsPostBack)
        //    {
        //        // Determine the sections to render
        //        if (HasPassword(manager))
        //        {
        //            ChangePassword.Visible = true;
        //        }
        //        else
        //        {
        //            CreatePassword.Visible = true;
        //            ChangePassword.Visible = false;
        //        }

        //        // Render success message
        //        var message = Request.QueryString["m"];
        //        if (message != null)
        //        {
        //            // Strip the query string from action
        //            Form.Action = ResolveUrl("~/Account/Manage");

        //            SuccessMessage =
        //                message == "ChangePwdSuccess" ? "Your password has been changed."
        //                : message == "SetPwdSuccess" ? "Your password has been set."
        //                : message == "RemoveLoginSuccess" ? "The account was removed."                        
        //                : String.Empty;
        //            successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
        //        }
        //    }
        //}


        //private void AddErrors(IdentityResult result)
        //{
        //    foreach (var error in result.Errors)
        //    {
        //        ModelState.AddModelError("", error);
        //    }
        //}

        public void UpdateUserProfile(string id)
        {
                        
            
            //if (Avatar.HasFile)
            //{
            //    if (Avatar.PostedFile.ContentType == "image/jpeg"
            //        || Avatar.PostedFile.ContentType == "image/png")
            //    {
            //        string filename = this.Context.User.Identity.GetUserId();

            //        var fileExtension = Avatar.PostedFile.ContentType.Split('/');

            //        filename += ".png";

            //        string path = Server.MapPath("~/images/") + filename;

            //        String RelativePath = path.Replace(Request.ServerVariables["APPL_PHYSICAL_PATH"], String.Empty);
            //        this.AvatarUrl = RelativePath;

            //        Avatar.SaveAs(path);

            //        this.AvatarUrl = "~/images/" + filename;
            //        this.OnUpdateProfile?.Invoke(this, new GetUserByIdEventArgs(this.Context, userId, RelativePath));
            //    }
            this.OnUpdateUserInfo?.Invoke(this, new UserDetailsEventArgs(this.Model.User, id));            
        }
    }
}