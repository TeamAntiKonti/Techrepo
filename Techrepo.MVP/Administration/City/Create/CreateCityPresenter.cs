using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.City.Create
{
    public class CreateCityPresenter: Presenter<ICreateCityView>
    {

        private readonly ICityService cityService;
        public CreateCityPresenter(ICreateCityView view, ICityService cityService) 
            : base(view)
        {
            this.cityService = cityService;
            this.View.OnCreateNewCity += View_OnCreateNewCity;
        }

        private void View_OnCreateNewCity(object sender, CreateCityEventArgs e)
        {
            this.cityService.CreateNewCity(e.Name);
        }
    }
}
