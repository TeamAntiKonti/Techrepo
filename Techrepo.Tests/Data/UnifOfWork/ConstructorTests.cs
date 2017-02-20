using Moq;
using NUnit.Framework;
using System;
using Techrepo.Data;

namespace Techrepo.Tests.Data.UnifOfWork
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void ShouldThrowArgumentNullExceptionContainingCannotBeNull_WhenNullIsPassed()
        {
            //Arrange
            var nullContext = (ITechrepoDbContext)null;

            //Act & Assert
            var exc = Assert.Throws<ArgumentNullException>(() => new UnitOfWork(nullContext));

            //Assert
            StringAssert.Contains("cannot be null", exc.Message);
        }

        [Test]
        public void ShouldNowThrowException_WhenValuesAreValid()
        {
            //Arrange
            var context = new Mock<ITechrepoDbContext>();

            //Act & Assert
            Assert.DoesNotThrow(() => new UnitOfWork(context.Object));
        }
        [Test]
        public void ShouldBeInstanceOfUnitOfWork()
        {
            //Arrange
            var context = new Mock<ITechrepoDbContext>();

            //Act
            var uof = new UnitOfWork(context.Object);

            //Assert
            Assert.IsInstanceOf<UnitOfWork>(uof);
        }

    }
}
