using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace Techrepo.MVP.Administration.Category.Create
{
    public interface ICreateCategoryView: IView<CreateCategoryViewModel>
    {
        event EventHandler<CreateCategoryEventArgs> OnCreateNewCategory;
    }
}
