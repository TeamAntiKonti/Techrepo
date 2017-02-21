using System.Collections.Generic;
using System.Linq;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface IAdvertCategoryService
    {
        IEnumerable<AdvertCategory> GetAllCategories();
        IQueryable<AdvertCategory> GetAllCategoriesSorted();
        void CreateNewCategory(AdvertCategory adCategoryName);
        AdvertCategory GetById(int id);
        void UpdateCategory(AdvertCategory category);
        void DeleteCategory(int id);
    }
}