﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data;
using Techrepo.Models;
using Techrepo.Tests.Data.Fakes;

namespace Techrepo.Tests.Data.GenericRepositoryTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void GenericRepoConstructor_ShouldThrowArgumentException_WhenContextIsNull()
        {
            //Arrange
            var techDbContext = (ITechrepoDbContext)null;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => new GenericRepository<AdvertCategory>(techDbContext));           
        }

        [Test]
        public void GenericRepoConstructor_ShouldSetInstanceOfFakeGenericRepository()
        {
            var techDbContext = new Mock<ITechrepoDbContext>();
            var genericRepo = new FakeGenericRepository<AdvertCategory>(techDbContext.Object);

            Assert.IsInstanceOf<FakeGenericRepository<AdvertCategory>>(genericRepo);
        }
        [Test]
        public void GenericRepoConstructor_ShouldNotThrowExceptionWhenCorrectValuesArePassed()
        {
            var techDbContext = new Mock<ITechrepoDbContext>();
            
            //Act & Assert
            Assert.DoesNotThrow(()=> new FakeGenericRepository<AdvertCategory>(techDbContext.Object));
        }
        [Test]
        public void GenericRepoConstructor_ShouldSetPropertyCorrectlyForContext()
        {
            //Arrange
            var techDbContext = new Mock<ITechrepoDbContext>();

            var genericRepo = new FakeGenericRepository<AdvertCategory>(techDbContext.Object);
            //Act & Assert
            Assert.AreSame(techDbContext.Object,genericRepo.Context);
        }
        [Test]
        public void GenericRepoConstructor_ShouldSetPropertyCorrectlyForDbSet()
        {
            //Arrange
            var techDbContext = new Mock<ITechrepoDbContext>();

            var genericRepo = new FakeGenericRepository<AdvertCategory>(techDbContext.Object);
            //Act & Assert
            Assert.AreSame(techDbContext.Object.Set<AdvertCategory>(), genericRepo.DbSet);
        }
    }
}
