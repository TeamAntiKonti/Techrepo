using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.MVP.Administration.Category.Create;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web.Administration.Category
{
    [PresenterBinding(typeof(CreateCategoryPresenter))]
    public partial class Create : MvpPage<CreateCategoryViewModel>,ICreateCategoryView
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
            if (IsValid)
            {
                this.OnCreateNewCategory?.Invoke(this, new CreateCategoryEventArgs(this.CategoryName.Text));
            }
        }
    }
}