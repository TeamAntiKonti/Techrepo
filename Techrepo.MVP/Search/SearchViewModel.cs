using System.Linq;
using Techrepo.Models;

namespace Techrepo.MVP.Search
{
    public class SearchViewModel
    {
        public IQueryable<Advert> Adverts { get; set; }
    }
}