using System;
using Techrepo.MVP.Administration.CreateCityNamespace;
using WebFormsMvp;

namespace Techrepo.MVP.Adverts
{
    public interface IAdvertsView:IView<AdvertsViewModel>
    {
        event EventHandler OnAdvertsGetData;
        event EventHandler<IdEventArgs> OnDeleteAdvert;
    }
}
