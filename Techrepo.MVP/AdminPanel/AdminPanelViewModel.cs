using System.Collections.Generic;
using Techrepo.Models;

namespace Techrepo.MVP.AdminPanel
{
    public class AdminPanelViewModel
    {
        public IEnumerable<AdvertCategory> advertCategories { get; set; }
    }
}
