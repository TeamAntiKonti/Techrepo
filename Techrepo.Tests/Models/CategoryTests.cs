using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Techrepo.Models;

namespace Techrepo.Tests.Models
{
    [TestFixture]
    public class CategoryTests
    {
        [Test]
        public void Category_ShouldNotBeNull()
        {
            //Arrange & Act
            var category = new AdvertCategory();

            //Assert
            Assert.IsNotNull(category);
        }

        [Test]
        public void Category_ShouldBeOfOfTypeAdvertCategory()
        {
            //Arrange & Act
            var category = new AdvertCategory();

            //Assert
            Assert.IsInstanceOf<AdvertCategory>(category);
        }
        [Test]
        public void Category_AdvertsOfCategoryShouldNotBeNull()
        {
            //Arrange & Act
            var category = new AdvertCategory();
            var adverts = category.Adverts;

            //Assert
            Assert.IsNotNull(adverts);
        }
        [Test]
        public void Category_AdvertsShouldBeInstanceOfICollectionOfAdverts()
        {
            //Arrange & Act
            var category = new AdvertCategory();
            var adverts = category.Adverts;

            //Assert
            Assert.IsInstanceOf<ICollection<Advert>>(adverts);
        }

        [Test]
        public void Category_NameShouldBeRequiredAndShouldNotBeNull()
        {
            //Arrange & Act
            var categoryName = typeof(AdvertCategory).GetProperty("Name");
            //using reflection
            var attribute = categoryName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute); ;
        }

        [Test]
        public void Category_IdShouldBeKeyAttribute()
        {
            //Arrange & Act
            var categoryId = typeof(AdvertCategory).GetProperty("Id");
            //using reflection
            var attribute = categoryId.GetCustomAttribute(typeof(KeyAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }
    }
}
