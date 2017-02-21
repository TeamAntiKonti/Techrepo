using System;
using System.Web.ModelBinding;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.CreateCityNamespace
{
    public interface ICreateCityView: IView<CreateCityViewModel>
    {
        event EventHandler OnGetAllCities;
        event EventHandler<IdEventArgs> OnUpdateCity;
        event EventHandler OnCreateNewCity;
        event EventHandler<IdEventArgs> OnDelete;
        ModelStateDictionary ModelState { get; }

        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}
