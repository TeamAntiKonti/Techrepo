using System;
using System.Collections.Generic;
using System.Linq;
using Techrepo.Data.Contracts;
using Techrepo.Data;
using Techrepo.Models;

namespace Techrepo.Services
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<City> repository;
        public CityService(IUnitOfWork unitOfWork, IRepository<City> repository)
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

        public void CreateNewCity(City city)
        {
            this.repository.Add(city);
            this.unitOfWork.Commit();
        }

        public IQueryable<City> GetAllCities()
        {
            return this.repository.All().OrderBy(city => city.Name);
        }

        public City GetById(int id)
        {
            return this.repository.GetById(id);
        }
        
        public void UpdateCity(City city)
        {
            City cityToBeUpdated = this.GetById(city.Id);
            cityToBeUpdated = city;

            this.unitOfWork.Commit();
        }

        public void DeleteCity(int id)
        {
            City city = this.repository.GetById(id);
            this.repository.Delete(city);
            this.unitOfWork.Commit();
        }
    }
}
