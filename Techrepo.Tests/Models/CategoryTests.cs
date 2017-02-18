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
            var category = typeof(AdvertCategory).GetProperty("Name");
            //using reflection
            var attribute = category.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute); ;
        }

        [Test]
        public void Category_IdShouldBeKeyAttribute()
        {
            var category = typeof(AdvertCategory).GetProperty("Id");
            //using reflection
            var attribute = category.GetCustomAttribute(typeof(KeyAttribute));
            Assert.IsNotNull(attribute); ;
        }


    }
}
