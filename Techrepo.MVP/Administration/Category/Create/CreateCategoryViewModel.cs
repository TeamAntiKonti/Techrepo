using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Models;

namespace Techrepo.MVP.Administration.Category.Create
{
    public class CreateCategoryViewModel
    {
        public IEnumerable<AdvertCategory> advertCategories { get; set; }
    }
}
