using System;
using Techrepo.MVP.Administration.CreateCityNamespace;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.Adverts
{
    public class AdvertsPresenter : Presenter<IAdvertsView>
    {
        private readonly IAdvertsService advertsService;

        public AdvertsPresenter(IAdvertsView view,IAdvertsService advertsService) 
            : base(view)
        {
            this.advertsService = advertsService;

            this.View.OnAdvertsGetData += this.View_OnAdvertsGetData;
            this.View.OnDeleteAdvert += View_OnDeleteAdvert;
        }

        private void View_OnDeleteAdvert(object sender, IdEventArgs e)
        {
            this.advertsService.DeleteAdvert(e.Id);
        }

        private void View_OnAdvertsGetData(object sender,EventArgs e)
        {
            this.View.Model.Adverts = this.advertsService.GetAllAdverts();
        }
    }
}
