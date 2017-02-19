using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data.Contracts;
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

        public void CreateNewCity(string cityName)
        {
            //factory maybe?
            City city = new City();
            city.Name = cityName;

            this.repository.Add(city);
            this.unitOfWork.Commit();
        }

        public IEnumerable<City> GetAllCities()
        {
            return this.repository.GetAll();
        }
    }
}
