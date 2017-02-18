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
            var category = new AdvertCategory();
            Assert.IsNotNull(category);
        }

        [Test]
        public void Category_ShouldBeOfOfTypeAdvertCategory()
        {
            var category = new AdvertCategory();
            Assert.IsInstanceOf<AdvertCategory>(category);
        }
        [Test]
        public void Category_AdvertsOfCategoryShouldNotBeNull()
        {
            var category = new AdvertCategory();
            var adverts = category.Adverts;
            Assert.IsNotNull(adverts);
        }
        [Test]
        public void Category_AdvertsShouldBeInstanceOfICollectionOfAdverts()
        {
            var category = new AdvertCategory();
            var adverts = category.Adverts;
            
            Assert.IsInstanceOf<ICollection<Advert>>(adverts);
        }

        [Test]
        public void Category_NameShouldBeRequiredAndShouldNotBeNull()
        {
            var categoryName = typeof(AdvertCategory).GetProperty("Name");
            //using reflection
            var attribute = categoryName.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute); ;
        }

        [Test]
        public void Category_IdShouldBeKeyAttribute()
        {
            var categoryId = typeof(AdvertCategory).GetProperty("Id");
            //using reflection
            var attribute = categoryId.GetCustomAttribute(typeof(KeyAttribute));
            Assert.IsNotNull(attribute); 
        }


    }
}
