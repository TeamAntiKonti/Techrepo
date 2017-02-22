using Techrepo.Models;
using Techrepo.MVP.Administration.CreateCityNamespace;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.AdvertDetails
{
    public class AdvertDetailsPresenter : Presenter<IAdvertDetailsView>
    {
        private readonly IAdvertsService advertService;

        public AdvertDetailsPresenter(IAdvertDetailsView view, IAdvertsService advertService) 
            : base(view)
        {
            this.advertService = advertService;
            this.View.OnAdvertDetails += View_OnAdvertDetails;
            this.View.OnUpdateAdvert += View_OnUpdateAdvert;
        }

        private void View_OnUpdateAdvert(object sender, IdEventArgs e)
        {
            Advert advert = this.advertService.GetById(e.Id);

            if(advert == null)
            {
                this.View.ModelState.AddModelError("", string.Format("", "Advert with id {0} does not exist", e.Id));
                return;
            }

            this.View.TryUpdateModel(advert);
            if (this.View.ModelState.IsValid)
            {
                this.advertService.UpdateAdvert(advert);
            }
        }

        private void View_OnAdvertDetails(object sender,AdvertDetailsEventArgs e)
        {
            this.View.Model.Advert = this.advertService.GetById(e.Id);           
        }

    }
}
