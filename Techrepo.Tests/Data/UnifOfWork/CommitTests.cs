using Moq;
using NUnit.Framework;
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
