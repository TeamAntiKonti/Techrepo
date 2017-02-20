using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techrepo.MVP.AdvertDetails
{
    public class AdvertDetailsEventArgs:EventArgs
    {
        public AdvertDetailsEventArgs(int? id)
        {
            this.Id = id;
        }

        public int? Id { get; private set; }
    }
}
