using System;
using System.Linq;
using System.Web.UI.WebControls;
using Techrepo.Models;
using Techrepo.MVP.Administration.CreateCityNamespace;
using Techrepo.MVP.Adverts;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(AdvertsPresenter))]
    public partial class Adverts : MvpPage<AdvertsViewModel>, IAdvertsView
    {
        public event EventHandler OnAdvertsGetData;
        public event EventHandler<IdEventArgs> OnDeleteAdvert;
        public IQueryable<Advert> ListViewAdverts_GetData()
        {
            this.OnAdvertsGetData?.Invoke(this, null);
            return this.Model.Adverts;
        }

        protected void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse((string)e.CommandArgument);

            this.OnDeleteAdvert?.Invoke(this, new IdEventArgs(id));
        }
    }
}