using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Techrepo.Models;

namespace Techrepo.Tests.Models
{
    [TestFixture]
    public class AdvertsTests
    {
        [Test]
        public void Advert_ShouldNotBeNull()
        {
            var advert = new Advert();
            Assert.IsNotNull(advert);
        }

        [Test]
        public void Advert_IsInstanceOfAdvert()
        {
            var advert = new Advert();
            Assert.IsInstanceOf<Advert>(advert);
        }

        [Test]
        public void Advert_SubscribersShouldNotBeNull()
        {
            var advert = new Advert();
            var subscribers = advert.Subscribers;
            Assert.IsNotNull(subscribers);
        }

        [Test]
        public void Advert_SubscribersShouldBeICollectionOfUsers()
        {
            var advert = new Advert();
            var subscribers = advert.Subscribers;
            Assert.IsInstanceOf<ICollection<User>>(subscribers);
        }
        [Test]
        public void Advert_IdShouldBeKeyAttribute()
        {

            var advertId = typeof(Advert).GetProperty("Id");
            //using reflection
            var attribute = advertId.GetCustomAttribute(typeof(KeyAttribute));
            Assert.IsNotNull(attribute);

        }

        [Test]
        public void Advert_TitleShouldBeRequiredAndShouldNotBeNull()
        {
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute); 
        }
        [Test]
        public void Advert_TitleShouldHaveMinLengthAttribute()
        {
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(MinLengthAttribute));
            Assert.IsNotNull(attribute);
        }
        [Test]
        public void Advert_TitleShouldHaveMaxLengthAttribute()
        {
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(MaxLengthAttribute));
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void Advert_PriceShouldBeRequiredAndShouldNotBeNull()
        {
            var advertPrice = typeof(Advert).GetProperty("Price");
            //using reflection
            var attribute = advertPrice.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(attribute);
        }

    }
}
