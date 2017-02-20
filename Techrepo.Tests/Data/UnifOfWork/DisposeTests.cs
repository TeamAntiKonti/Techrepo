using Moq;
using NUnit.Framework;
using Techrepo.Data;

namespace Techrepo.Tests.Data.UnifOfWork
{
    [TestFixture]
    public class DisposeTests
    {
        [Test]
        public void ShouldNotThrowExc()
        {
            //Arrange
            var context = new Mock<ITechrepoDbContext>();
            var uof = new UnitOfWork(context.Object);

            //Act & Assert
            Assert.DoesNotThrow(() => uof.Dispose());
        }
    }
}
