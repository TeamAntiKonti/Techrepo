using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data;
using System.Data;
using System.Data.Entity;

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
