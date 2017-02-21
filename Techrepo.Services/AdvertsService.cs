using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data;
using Techrepo.Models;

namespace Techrepo.Services
{
    public class AdvertsService : IAdvertsService
    {
        private readonly ITechrepoDbContext techrepoContext;

        public AdvertsService(ITechrepoDbContext techrepoContext)
        {
            this.techrepoContext = techrepoContext;
        }

        public IQueryable<Advert> GetAllAdverts()
        {
            return this.techrepoContext.Adverts;
        }

        public void CreateAdvert(Advert advert)
        {
            this.techrepoContext.Adverts.Add(advert);
            this.techrepoContext.SaveChanges();
        }

        public Advert GetById(int? id)
        {
            return id.HasValue ? this.techrepoContext.Adverts.Find(id) : null;
        }

        public IQueryable<Advert> GetAdvertByTitleOrDescription(string searchTerm)
        {
            return string.IsNullOrEmpty(searchTerm) ?this.techrepoContext.Adverts
                :this.techrepoContext.Adverts.Where(a=>
                (string.IsNullOrEmpty(a.Title) ? false : a.Title.Contains(searchTerm))
                ||
                (string.IsNullOrEmpty(a.Description)?false:a.Description.Contains(searchTerm)));
        }
    }
}
