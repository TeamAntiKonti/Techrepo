using Moq;
using NUnit.Framework;
using System.Data.Entity;
using Techrepo.Data;
using Techrepo.Models;
using Techrepo.Tests.Data.Fakes;

namespace Techrepo.Tests.Data.GenericRepositoryTests
{
    [TestFixture]
    public class GetByIdTests
    {
        [Test]
        public void ShouldCallFindMethod()
        {
            //Arrange
            var id = 5;
            var techDbContext = new Mock<ITechrepoDbContext>();
            var dbSetMock = new Mock<DbSet<AdvertCategory>>();
            techDbContext.Setup(t => t.Set<AdvertCategory>()).Returns(dbSetMock.Object);
            var genericRepo = new FakeGenericRepository<AdvertCategory>(techDbContext.Object);

            //Act
            genericRepo.GetById(id);

            //Assert
            dbSetMock.Verify(d => d.Find(id), Times.Once);

        }
    }
}
