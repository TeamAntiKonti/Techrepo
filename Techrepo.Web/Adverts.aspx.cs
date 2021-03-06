﻿using System;
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

        public void ListView_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (this.Context.User.IsInRole("Admin"))
            {
                if (e.Item.ItemType == ListViewItemType.DataItem)
                {
                    var btn = (Button)e.Item.FindControl("BtnDel");
                    btn.CssClass = "visible btn btn-danger";
                }                
            }
        }
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

        protected void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse((string)e.CommandArgument);

            this.OnDeleteAdvert?.Invoke(this, new IdEventArgs(id));

        }
    }
}