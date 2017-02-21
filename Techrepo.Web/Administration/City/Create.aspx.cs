using System;
using System.Linq;
using Techrepo.MVP.Administration.CreateCityNamespace;
using WebFormsMvp;
using WebFormsMvp.Web;
using Techrepo.Models;

namespace Techrepo.Web.Administration.CreateCityNamespace
{
    [PresenterBinding(typeof(CreateCityPresenter))]
    public partial class Create : MvpPage<CreateCityViewModel>, ICreateCityView
    {
        public event EventHandler OnCreateNewCity;
        public event EventHandler OnGetAllCities;
        public event EventHandler<IdEventArgs> OnUpdateCity;
        public event EventHandler<IdEventArgs> OnDelete;

        protected string SuccessMessage
        {
            get;
            private set;
        }

        public IQueryable<City> ListView1_GetData()
        {
            this.OnGetAllCities?.Invoke(this, null);

            return this.Model.Cities;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListView1_UpdateItem(int id)
        {
            this.OnUpdateCity?.Invoke(this, new IdEventArgs(id));       
        }

        public void ListView1_InsertItem()
        {
            this.OnCreateNewCity?.Invoke(this, null);
        }

        public void ListView1_DeleteItem(int id)
        {
            this.OnDelete?.Invoke(this, new IdEventArgs(id));
        }
    }
}