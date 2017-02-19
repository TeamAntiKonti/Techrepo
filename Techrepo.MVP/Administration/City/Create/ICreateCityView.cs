using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.City.Create
{
    public interface ICreateCityView: IView<CreateCityViewModel>
    {
        event EventHandler<CreateCityEventArgs> OnCreateNewCity;
    }
}
