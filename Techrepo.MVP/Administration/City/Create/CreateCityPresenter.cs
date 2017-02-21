using System;
using Techrepo.Models;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.CreateCityNamespace
{
    public class CreateCityPresenter: Presenter<ICreateCityView>
    {

        private readonly ICityService cityService;
        public CreateCityPresenter(ICreateCityView view, ICityService cityService) 
            : base(view)
        {
            this.cityService = cityService;
            this.View.OnCreateNewCity += View_OnCreateNewCity;
            this.View.OnGetAllCities += View_OnGetAllCities;
            this.View.OnUpdateCity += View_OnUpdateCity;
            this.View.OnDelete += View_OnDelete;
        }

        private void View_OnDelete(object sender, IdEventArgs e)
        {
            this.cityService.DeleteCity(e.Id);
        }

        private void View_OnUpdateCity(object sender, IdEventArgs e)
        {
            City city = this.cityService.GetById(e.Id);

            if(city == null)
            {
                this.View.ModelState.AddModelError("", string.Format("City with id {0} does not exist", e.Id));
                return;
            }

            this.View.TryUpdateModel(city);
            if(this.View.ModelState.IsValid)
            {
                this.cityService.UpdateCity(city);
            }
        }

        private void View_OnGetAllCities(object sender, EventArgs e)
        {
            this.View.Model.Cities = this.cityService.GetAllCities();
        }

        private void View_OnCreateNewCity(object sender, EventArgs e)
        {
            City newCity = new City();
            this.View.TryUpdateModel(newCity);

            if(this.View.ModelState.IsValid)
            {
                this.cityService.CreateNewCity(newCity);
            }
        }
    }
}
