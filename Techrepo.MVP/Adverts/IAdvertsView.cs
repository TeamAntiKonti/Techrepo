using System;
using WebFormsMvp;

namespace Techrepo.MVP.Adverts
{
    public interface IAdvertsView:IView<AdvertsViewModel>
    {
        event EventHandler OnAdvertsGetData;
    }
}
