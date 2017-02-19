using System;
using WebFormsMvp;

namespace Techrepo.MVP.CreateAdvert
{
    public interface ICreateAdvertView : IView<CreateAdvertViewModel>
    {
        event EventHandler<CreateAdvertEventArgs> OnCreateAdvert;
        event EventHandler CustomOnInit;
    }
}
