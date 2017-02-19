using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.MVP.Administration.City.Create;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Techrepo.Web.Administration.City
{
    [PresenterBinding(typeof(CreateCityPresenter))]
    public partial class Create : MvpPage<CreateCityViewModel>, ICreateCityView
    {
        public event EventHandler<CreateCityEventArgs> OnCreateNewCity;


        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateCity_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                this.OnCreateNewCity?.Invoke(this, new CreateCityEventArgs(this.CityName.Text));
            }
        }
    }
}