using System;
using System.Linq;
using Techrepo.Models;
using Techrepo.MVP.Administration.Category.Create;
using Techrepo.MVP.Administration.CreateCityNamespace;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web.Administration.Category
{
    [PresenterBinding(typeof(CreateCategoryPresenter))]
    public partial class Create : MvpPage<CreateCategoryViewModel>, ICreateCategoryView
    {
        public event EventHandler OnCreateNewCategory;
        public event EventHandler OnGetAllCategories;
        public event EventHandler<IdEventArgs> OnUpdateCategory;
        public event EventHandler<IdEventArgs> OnDeleteCategory;

        protected string SuccessMessage
        {
            get;
            private set;
        }

        public IQueryable<AdvertCategory> ListView1_GetData()
        {
            this.OnGetAllCategories?.Invoke(this, null);

            return this.Model.AdvertCategories;
        }

        public void ListView1_InsertItem()
        {
            this.OnCreateNewCategory?.Invoke(this, null);
        }

        public void ListView1_UpdateItem(int id)
        {
            this.OnUpdateCategory?.Invoke(this, new IdEventArgs(id));
        }

        public void ListView1_DeleteItem(int id)
        {
            this.OnDeleteCategory?.Invoke(this, new IdEventArgs(id));
        }
    }
}