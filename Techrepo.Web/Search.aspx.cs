using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.Models;
using Techrepo.MVP.Search;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(SearchPresenter))]
    public partial class Search : MvpPage<SearchViewModel>,ISearchView
    {
        public event EventHandler<SearchEventArgs> OnRepeaterGetData;

        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}
        public IQueryable<Advert> Repeater_GetData([QueryString] string q)
        {
            this.OnRepeaterGetData?.Invoke(this, new SearchEventArgs(q));
            return this.Model.Adverts;
        }

    }
}