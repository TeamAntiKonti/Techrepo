using System;
using System.Linq;
using Techrepo.Models;
using Techrepo.MVP.Adverts;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(AdvertsPresenter))]
    public partial class Adverts : MvpPage<AdvertsViewModel>, IAdvertsView
    {
        //private readonly ITechrepoDbContext dbContext;

        public event EventHandler OnAdvertsGetData;

        //public Adverts()
        //{
        //    this.dbContext = new TechrepoDbContext();
        //}

        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}
        public IQueryable<Advert> ListViewAdverts_GetData()
        {
            this.OnAdvertsGetData?.Invoke(this, null);
            return this.Model.Adverts;
        }
    }
}