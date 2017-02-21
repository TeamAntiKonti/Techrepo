using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface ICityService
    {
        IQueryable<City> GetAllCities();

        City GetById(int id);
        void CreateNewCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int id);
    }
}
