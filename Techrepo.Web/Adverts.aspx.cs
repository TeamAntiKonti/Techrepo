using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.Data;
using Techrepo.Models;
using Techrepo.Services;

namespace Techrepo.Web
{
    public partial class Adverts : System.Web.UI.Page
    {
        private readonly ITechrepoDbContext dbContext;
        public Adverts()
        {
            this.dbContext = new TechrepoDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Advert> ListViewAdverts_GetData()
        {
            //var advert1 = new Advert();
            //advert1.Price = 34;
            //advert1.Description = "cool advert";
            //var advert2 = new Advert();
            //advert2.Price = 64;
            //advert2.Description = "cool advert2";
            //var list = new List<Advert>() { advert1,advert2 };
            //return list.AsQueryable();

            return dbContext.Adverts;
        }
    }
}