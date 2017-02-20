using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data;

namespace Techrepo.Tests.Data.UnifOfWork
{
    [TestFixture]
    public class CommitTests
    {
        [Test]
        public void ShouldCallSaveChangesOnContext()
        {
            //Arrange
            var context = new Mock<ITechrepoDbContext>();
            var uof = new UnitOfWork(context.Object);

            //Act
            uof.Commit();

            //Assert
            context.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
