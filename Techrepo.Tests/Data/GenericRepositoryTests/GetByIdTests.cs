using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var id = 5;

            var techDbContext = new Mock<ITechrepoDbContext>();
            var dbSetMock = new Mock<DbSet<AdvertCategory>>();
            techDbContext.Setup(t => t.Set<AdvertCategory>()).Returns(dbSetMock.Object);
            var genericRepo = new FakeGenericRepository<AdvertCategory>(techDbContext.Object);
            
            

            genericRepo.GetById(id);
            dbSetMock.Verify(d => d.Find(id), Times.Once);

        }
    }
}
