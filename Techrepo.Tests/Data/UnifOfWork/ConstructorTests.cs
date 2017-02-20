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
    public class ConstructorTests
    {
        [Test]
        public void ShouldThrowArgumentNullExceptionContainingCannotBeNull_WhenNullIsPassed()
        {
            var nullContext = (ITechrepoDbContext)null;

            var exc = Assert.Throws<ArgumentNullException>(() => new UnitOfWork(nullContext));

            StringAssert.Contains("cannot be null", exc.Message);
        }

        [Test]
        public void ShouldNowThrowException_WhenValuesAreValid()
        {
            var context = new Mock<ITechrepoDbContext>();

            Assert.DoesNotThrow(() => new UnitOfWork(context.Object));
        }
        [Test]
        public void ShouldBeInstanceOfUnitOfWork()
        {
            var context = new Mock<ITechrepoDbContext>();

            var uof = new UnitOfWork(context.Object);

            Assert.IsInstanceOf<UnitOfWork>(uof);
        }

    }
}
