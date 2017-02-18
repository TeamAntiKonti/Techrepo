using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Models;

namespace Techrepo.Tests.Models
{
    [TestFixture]
    public class CityTests
    {
        [Test]
        public void City_ShouldNotBeNull()
        {
            var city = new City();
            Assert.IsNotNull(city);
        }
        [Test]
        public void City_ShouldBeInstanceOfCity()
        {
            var city = new City();
            Assert.IsInstanceOf<City>(city);
        }
        [Test]
        public void City_AdvertsShouldNotBeNull()
        {
            var city = new City();
            var advertsCity = city.Adverts;
            Assert.IsNotNull(advertsCity);
        }
        [Test]
        public void City_AdvertsShouldBeInstanceOfICollectionOfAdverts()
        {
            var city = new City();
            var advertsCity = city.Adverts;
            Assert.IsInstanceOf<ICollection<Advert>>(advertsCity);
        }
        [Test]
        public void City_IdShouldBeKeyAttribute()
        {

            var city = typeof(City).GetProperty("Id");
            //using reflection
            var attribute = city.GetCustomAttribute(typeof(KeyAttribute));
            Assert.IsNotNull(attribute);

        }
        [Test]
        public void City_NameShouldBeRequiredAndShouldNotBeNull()
        {
            var city = typeof(City).GetProperty("Name");
            //using reflection
            var attribute = city.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute); ;
        }
    }
}
