using System.Collections.Generic;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface IAdvertCategoryService
    {
        IEnumerable<AdvertCategory> GetAllCategories();
        void CreateNewCategory(string adCategoryName);
    }
}