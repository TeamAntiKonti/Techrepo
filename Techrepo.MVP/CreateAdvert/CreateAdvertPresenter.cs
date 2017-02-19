using System;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.CreateAdvert
{
    public class CreateAdvertPresenter : Presenter<ICreateAdvertView>
    {
        private readonly IAdvertCategoryService advertsCategoryService;
        private readonly ICityService cityService;
        private readonly IAdvertsService advertsService;

        public CreateAdvertPresenter(ICreateAdvertView view, 
            IAdvertCategoryService adCategoryService, ICityService cityService, IAdvertsService adsService) 
            : base(view)
        {
            this.advertsCategoryService = adCategoryService;
            this.cityService = cityService;
            this.advertsService = adsService;
            this.View.CustomOnInit += View_CustomOnInit;
            this.View.OnCreateAdvert += View_OnCreateAdvert;
        }

        private void View_OnCreateAdvert(object sender, CreateAdvertEventArgs e)
        {
            this.advertsService.CreateAdvert(e.Advert);
        }

        private void View_CustomOnInit(object sender, EventArgs e)
        {            
            this.View.Model.AdvertCategories = this.advertsCategoryService.GetAllCategories();
            this.View.Model.Cities = this.cityService.GetAllCities();
        }
    }
}
