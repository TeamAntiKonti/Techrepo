using System.Linq;
using Techrepo.Models;

namespace Techrepo.MVP.Adverts
{
    public class AdvertsViewModel
    {
        public IQueryable<Advert> Adverts { get; set; }
    }
}
