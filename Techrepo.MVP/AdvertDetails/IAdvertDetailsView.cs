using System;
using System.Web.ModelBinding;
using Techrepo.MVP.Administration.CreateCityNamespace;
using WebFormsMvp;

namespace Techrepo.MVP.AdvertDetails
{
    public interface IAdvertDetailsView:IView<AdvertDetailsViewModel>
    {
        event EventHandler<AdvertDetailsEventArgs> OnAdvertDetails;
        event EventHandler<IdEventArgs> OnUpdateAdvert;
        ModelStateDictionary ModelState { get; }
        bool TryUpdateModel<TModel>(TModel model) where TModel : class;
    }
}
