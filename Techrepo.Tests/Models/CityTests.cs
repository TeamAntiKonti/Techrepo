using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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

            var cityId = typeof(City).GetProperty("Id");
            //using reflection
            var attribute = cityId.GetCustomAttribute(typeof(KeyAttribute));
            Assert.IsNotNull(attribute);

        }
        [Test]
        public void City_NameShouldBeRequiredAndShouldNotBeNull()
        {
            var cityName = typeof(City).GetProperty("Name");
            //using reflection
            var attribute = cityName.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute); ;
        }
    }
}
