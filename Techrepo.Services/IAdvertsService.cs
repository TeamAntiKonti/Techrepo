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
<<<<<<< HEAD

        IQueryable<Advert> GetAdvertByTitleOrDescription(string searchTerm);

=======
        void DeleteAdvert(int id);
>>>>>>> 663d7666978c5005813f94786b94f8d7f4d58f77
    }
}
