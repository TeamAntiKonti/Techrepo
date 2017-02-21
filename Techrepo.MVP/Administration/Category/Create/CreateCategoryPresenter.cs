using System;
using Techrepo.Models;
using Techrepo.MVP.Administration.CreateCityNamespace;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.Category.Create
{
    public class CreateCategoryPresenter:Presenter<ICreateCategoryView>
    {
        private readonly IAdvertCategoryService advertCategoryService;
        public CreateCategoryPresenter(ICreateCategoryView view, IAdvertCategoryService advertCategoryService) 
            : base(view)
        {
            this.advertCategoryService = advertCategoryService;
            this.View.OnGetAllCategories += View_OnGetAllCategories;
            this.View.OnCreateNewCategory += View_OnCreateNewCategory;
            this.View.OnUpdateCategory += View_OnUpdateCategory;
            this.View.OnDeleteCategory += View_OnDeleteCategory;
        }

        private void View_OnDeleteCategory(object sender, IdEventArgs e)
        {
            this.advertCategoryService.DeleteCategory(e.Id);
        }

        private void View_OnUpdateCategory(object sender, IdEventArgs e)
        {
            AdvertCategory category = this.advertCategoryService.GetById(e.Id);

            if (category == null)
            {
                this.View.ModelState.AddModelError("", string.Format("Category with id {0} does not exist", e.Id));
                return;
            }

            this.View.TryUpdateModel(category);
            if (this.View.ModelState.IsValid)
            {
                this.advertCategoryService.UpdateCategory(category);
            }
        }

        private void View_OnCreateNewCategory(object sender, EventArgs e)
        {
            AdvertCategory newCategory = new AdvertCategory();
            this.View.TryUpdateModel(newCategory);

            if (this.View.ModelState.IsValid)
            {
                this.advertCategoryService.CreateNewCategory(newCategory);
            }
        }

        private void View_OnGetAllCategories(object sender, EventArgs e)
        {
            this.View.Model.AdvertCategories = this.advertCategoryService.GetAllCategoriesSorted();
        }
    }
}
