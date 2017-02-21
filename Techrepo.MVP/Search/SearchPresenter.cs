using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Services;
using WebFormsMvp;

namespace Techrepo.MVP.Search
{
    public class SearchPresenter:Presenter<ISearchView>
    {
        private readonly IAdvertsService advertService;

        public SearchPresenter(ISearchView view, IAdvertsService advertService)
            : base(view)
        {
           if(advertService == null)
            {
                throw new ArgumentNullException("Service cannot be null");
            }


            this.advertService = advertService;

            this.View.OnRepeaterGetData += this.View_OnRepeaterGetData;
        }

        private void View_OnRepeaterGetData(object sender, SearchEventArgs e)
        {
            this.View.Model.Adverts = this.advertService.GetAdvertByTitleOrDescription(e.QueryParams);
        }
    }
}
