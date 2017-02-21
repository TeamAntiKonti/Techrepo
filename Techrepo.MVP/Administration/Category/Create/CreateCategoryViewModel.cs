using System.Linq;
using Techrepo.Models;

namespace Techrepo.MVP.Administration.Category.Create
{
    public class CreateCategoryViewModel
    {
        public IQueryable<AdvertCategory> AdvertCategories { get; set; }
    }
}
