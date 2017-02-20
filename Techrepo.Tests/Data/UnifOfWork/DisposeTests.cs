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
    public class DisposeTests
    {
        [Test]
        public void ShouldNotThrowExc()
        {
            var context = new Mock<ITechrepoDbContext>();

            var uof = new UnitOfWork(context.Object);

            Assert.DoesNotThrow(() => uof.Dispose());
        }
    }
}
