using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.View.OnCreateNewCategory += View_OnCreateNewCategory;
        }

        private void View_OnCreateNewCategory(object sender, CreateCategoryEventArgs e)
        {
            this.advertCategoryService.CreateNewCategory(e.Name);
        }
    }
}
