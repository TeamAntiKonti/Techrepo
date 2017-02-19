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

        public void CreateNewCategory(string adCategoryName)
        {
            //should it be like this?
            AdvertCategory newAd = new AdvertCategory();
            newAd.Name = adCategoryName;

            this.repository.Add(newAd);
            this.unitOfWork.Commit();            
        }
    }
}
