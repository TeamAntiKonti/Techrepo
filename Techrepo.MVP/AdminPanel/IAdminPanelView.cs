using System;
using WebFormsMvp;

namespace Techrepo.MVP.AdminPanel
{
    public interface IAdminPanelView : IView<AdminPanelViewModel>
    {
        event EventHandler<CreateCategoryEventArgs> OnCreateNewCategory;

       // event EventHandler<CreateCityEventArgs> OnCreateNewCity;
    }
}
