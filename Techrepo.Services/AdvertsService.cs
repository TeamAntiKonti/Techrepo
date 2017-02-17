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
    }
}
