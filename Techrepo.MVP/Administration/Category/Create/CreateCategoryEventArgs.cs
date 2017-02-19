using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techrepo.MVP.Administration.Category.Create
{
    public class CreateCategoryEventArgs:EventArgs
    {

        public CreateCategoryEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
