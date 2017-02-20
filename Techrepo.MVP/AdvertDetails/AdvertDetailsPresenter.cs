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
            this.View.OnAdvertDetails += this.View_OnAdvertDetails;
        }

        private void View_OnAdvertDetails(object sender,AdvertDetailsEventArgs e)
        {
            this.View.Model.Advert = this.advertService.GetById(e.Id);
           
        }

    }
}
