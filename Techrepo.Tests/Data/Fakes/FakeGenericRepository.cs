using System.Data.Entity;
using Techrepo.Data;

namespace Techrepo.Tests.Data.Fakes
{
    public class FakeGenericRepository<T> : GenericRepository<T>
        where T : class
    {
        public FakeGenericRepository(ITechrepoDbContext context) : base(context)
        {
        }

        public ITechrepoDbContext Context
        {
            get
            {
                return base.Context;
            }
        }
        public IDbSet<T> DbSet
        {
            get
            {
                return base.DbSet;
            }
        }
    }
}
