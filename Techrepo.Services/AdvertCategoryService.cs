using System;
using System.Collections.Generic;
using System.Linq;
using Techrepo.Data.Contracts;
using Techrepo.Models;

namespace Techrepo.Services
{
    public class AdvertCategoryService : IAdvertCategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<AdvertCategory> repository;

        public AdvertCategoryService(IUnitOfWork unitOfWork, IRepository<AdvertCategory> repository)
        {
            // TODO: Global error messages
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("UnitOfWork cannot be null");
            }
            if (repository == null)
            {
                throw new ArgumentNullException("Repository cannot be null");
            }

            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        public IEnumerable<AdvertCategory> GetAllCategories()
        {
            return this.repository.GetAll();
        }

        public void CreateNewCategory(AdvertCategory adCategory)
        {
            this.repository.Add(adCategory);
            this.unitOfWork.Commit();            
        }

        public IQueryable<AdvertCategory> GetAllCategoriesSorted()
        {
            return this.repository.All();
        }

        public AdvertCategory GetById(int id)
        {
            return this.repository.GetById(id);
        }

        public void UpdateCategory(AdvertCategory c)
        {
            AdvertCategory categoryToBeUpdated = this.GetById(c.Id);
            categoryToBeUpdated = c;

            this.unitOfWork.Commit();
        }

        public void DeleteCategory(int id)
        {
            AdvertCategory adToBeDeleted = this.GetById(id);
            this.repository.Delete(adToBeDeleted);

            this.unitOfWork.Commit();
        }
    }
}
