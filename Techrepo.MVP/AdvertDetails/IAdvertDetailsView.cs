using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace Techrepo.MVP.AdvertDetails
{
    public interface IAdvertDetailsView:IView<AdvertDetailsViewModel>
    {
        event EventHandler<AdvertDetailsEventArgs> OnAdvertDetails;
    }
}
