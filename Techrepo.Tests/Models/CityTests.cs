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
            //Arrange & Act
            var city = new City();

            //Assert
            Assert.IsNotNull(city);
        }
        [Test]
        public void City_ShouldBeInstanceOfCity()
        {
            //Arrange & Act
            var city = new City();

            //Assert
            Assert.IsInstanceOf<City>(city);
        }
        [Test]
        public void City_AdvertsShouldNotBeNull()
        {
            //Arrange & Act
            var city = new City();
            var advertsCity = city.Adverts;

            //Assert
            Assert.IsNotNull(advertsCity);
        }
        [Test]
        public void City_AdvertsShouldBeInstanceOfICollectionOfAdverts()
        {
            //Arrange & Act
            var city = new City();
            var advertsCity = city.Adverts;

            //Assert
            Assert.IsInstanceOf<ICollection<Advert>>(advertsCity);
        }
        [Test]
        public void City_IdShouldBeKeyAttribute()
        {
            //Arrange & Act
            var cityId = typeof(City).GetProperty("Id");
            //using reflection
            var attribute = cityId.GetCustomAttribute(typeof(KeyAttribute));

            //Assert
            Assert.IsNotNull(attribute);

        }
        [Test]
        public void City_NameShouldBeRequiredAndShouldNotBeNull()
        {
            //Arrange & Act
            var cityName = typeof(City).GetProperty("Name");
            //using reflection
            var attribute = cityName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute); ;
        }
    }
}
