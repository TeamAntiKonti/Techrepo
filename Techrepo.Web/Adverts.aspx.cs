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

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string textToSearchFor = this.TextBoxSearchParam.Text;
            string queryParam = string.IsNullOrEmpty(textToSearchFor) ? string.Empty : string.Format("?q={0}", textToSearchFor);
            Response.Redirect("~/search" + queryParam);
        }
    }
}