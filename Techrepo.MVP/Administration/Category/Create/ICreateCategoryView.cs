using System;
using System.Web.ModelBinding;
using Techrepo.MVP.Administration.CreateCityNamespace;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.Category.Create
{
    public interface ICreateCategoryView: IView<CreateCategoryViewModel>
    {
        event EventHandler OnCreateNewCategory;
        event EventHandler OnGetAllCategories;
        event EventHandler<IdEventArgs> OnUpdateCategory;
        event EventHandler<IdEventArgs> OnDeleteCategory;
        ModelStateDictionary ModelState { get; }

        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}
