using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.Models;
using Techrepo.MVP.AdvertDetails;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(AdvertDetailsPresenter))]
    public partial class AdvertDetails :MvpPage<AdvertDetailsViewModel>,IAdvertDetailsView
    {
        public event EventHandler<AdvertDetailsEventArgs> OnAdvertDetails;

       public Advert FormViewAdvertDetails_GetItem([QueryString] int? id)
        {
            this.OnAdvertDetails?.Invoke(this, new AdvertDetailsEventArgs(id));
           
  
            return this.Model.Advert;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

       
    }
}