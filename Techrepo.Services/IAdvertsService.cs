using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface IAdvertsService
    {
        IQueryable<Advert> GetAllAdverts();
        void CreateAdvert(Advert advert);

        Advert GetById(int? id);

        IQueryable<Advert> GetAdvertByTitleOrDescription(string searchTerm);

    }
}
