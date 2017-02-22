using System.Linq;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface IAdvertsService
    {
        IQueryable<Advert> GetAllAdverts();
        void CreateAdvert(Advert advert);

        Advert GetById(int? id);


        IQueryable<Advert> GetAdvertByTitleOrDescription(string searchTerm);


        void DeleteAdvert(int id);
        void UpdateAdvert(Advert advert);

    }
}
