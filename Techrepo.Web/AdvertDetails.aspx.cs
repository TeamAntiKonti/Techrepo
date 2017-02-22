using System;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;
using Techrepo.Models;
using Techrepo.MVP.Administration.CreateCityNamespace;
using Techrepo.MVP.AdvertDetails;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(AdvertDetailsPresenter))]
    public partial class AdvertDetails :MvpPage<AdvertDetailsViewModel>,IAdvertDetailsView
    {
        public event EventHandler<AdvertDetailsEventArgs> OnAdvertDetails;
        public event EventHandler<IdEventArgs> OnUpdateAdvert;

       public Advert FormViewAdvertDetails_GetItem([QueryString] int? id)
        {
            this.OnAdvertDetails?.Invoke(this, new AdvertDetailsEventArgs(id));
           
  
            return this.Model.Advert;
        }

        public void UpdateAdvert(int id)
        {
            this.OnUpdateAdvert?.Invoke(this, new IdEventArgs(id));
        }
    }
}