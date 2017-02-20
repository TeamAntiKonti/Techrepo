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
            //Arrange & Act
            var advert = new Advert();

            //Assert
            Assert.IsNotNull(advert);
        }

        [Test]
        public void Advert_IsInstanceOfAdvert()
        {
            //Arrange & Act
            var advert = new Advert();

            //Assert
            Assert.IsInstanceOf<Advert>(advert);
        }

        [Test]
        public void Advert_SubscribersShouldNotBeNull()
        {
            //Arrange & Act
            var advert = new Advert();
            var subscribers = advert.Subscribers;

            //Assert
            Assert.IsNotNull(subscribers);
        }

        [Test]
        public void Advert_SubscribersShouldBeICollectionOfUsers()
        {
            //Arrange & Act
            var advert = new Advert();
            var subscribers = advert.Subscribers;

            //Assert
            Assert.IsInstanceOf<ICollection<User>>(subscribers);
        }
        [Test]
        public void Advert_IdShouldBeKeyAttribute()
        {
            //Arrange & Act
            var advertId = typeof(Advert).GetProperty("Id");
            //using reflection
            var attribute = advertId.GetCustomAttribute(typeof(KeyAttribute));

            //Assert
            Assert.IsNotNull(attribute);

        }

        [Test]
        public void Advert_TitleShouldBeRequiredAndShouldNotBeNull()
        {
            //Arrange & Act
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }
        [Test]
        public void Advert_TitleShouldHaveMinLengthAttribute()
        {
            //Arrange & Act
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(MinLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }
        [Test]
        public void Advert_TitleShouldHaveMaxLengthAttribute()
        {
            //Arrange & Act
            var advertTitle = typeof(Advert).GetProperty("Title");
            //using reflection
            var attribute = advertTitle.GetCustomAttribute(typeof(MaxLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void Advert_PriceShouldBeRequiredAndShouldNotBeNull()
        {
            //Arrange & Act
            var advertPrice = typeof(Advert).GetProperty("Price");
            //using reflection
            var attribute = advertPrice.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

    }
}
