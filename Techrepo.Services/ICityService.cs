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
        IEnumerable<City> GetAllCities();

        void CreateNewCity(string cityName);
    }
}
