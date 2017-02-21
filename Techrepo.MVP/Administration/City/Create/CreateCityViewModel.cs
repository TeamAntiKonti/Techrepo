using System.Linq;
using Techrepo.Models;

namespace Techrepo.MVP.Administration.CreateCityNamespace
{
    public class CreateCityViewModel
    {
        public IQueryable<City> Cities { get; set; }
        public City City { get; set; }
    }
}
