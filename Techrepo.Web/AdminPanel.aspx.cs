using System;
using Techrepo.MVP.AdminPanel;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(AdminPanelPresenter))]
    public partial class AdminPanel : MvpPage<AdminPanelViewModel>, IAdminPanelView
	{
        public event EventHandler<CreateCategoryEventArgs> OnCreateNewCategory;

        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected void Page_Load(object sender, EventArgs e)
		{            
        }

        protected void CreateCategory_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                this.OnCreateNewCategory?.Invoke(this, new CreateCategoryEventArgs(this.CategoryName.Text));
            }
        }
    }
}