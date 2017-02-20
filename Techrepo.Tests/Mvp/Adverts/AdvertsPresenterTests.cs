using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Techrepo.Models;
using Techrepo.MVP.Adverts;
using Techrepo.Services;

namespace Techrepo.Tests.Mvp.Adverts
{
    [TestFixture]
    public class AdvertsPresenterTests
    {
        [Test]
        public void View_OnAdvertsGetData_ShouldAddAdvertsToViewModel_WhenEventIsRaised()
        {
            //Arrange
            var viewMock = new Mock<IAdvertsView>();
            viewMock.Setup(v => v.Model).Returns(new AdvertsViewModel());
            var allAdverts = GetAllTheAdverts();
            var advertsServiceMock = new Mock<IAdvertsService>();
            advertsServiceMock.Setup(a => a.GetAllAdverts()).Returns(allAdverts);
            var advertsPresenter = new AdvertsPresenter(viewMock.Object, advertsServiceMock.Object);

            //Act
            viewMock.Raise(v => v.OnAdvertsGetData += null, EventArgs.Empty);

            //Assert
            CollectionAssert.AreEquivalent(allAdverts, viewMock.Object.Model.Adverts);
        }

        private IQueryable<Advert> GetAllTheAdverts()
        {
            var category = new AdvertCategory()
            {
                Id=48,
                Name="Camera"
            };
            var owner = new User()
            {
                FirstName="Gosho",
                LastName="Losho",
               
                
            };

            var adverts = new List<Advert>()
            {
                new Advert()
                {
                    Id=64,
                    Category=category,
                    CategoryId=category.Id,
                    Delivery=Delivery.BySalesman.ToString(),
                    Description="opisanieeeeeee",
                    Price=1245,
                    Title="zaglavieee",
                    ProductState=ProductState.New.ToString(),
                    Owner= owner,
                    OwnerEmail="sdgsg@abv.bg",
                    OwnerId="346",
                    OwnerPhone="346899"


                }
            };
            return adverts.AsQueryable();
        }
    }
}
