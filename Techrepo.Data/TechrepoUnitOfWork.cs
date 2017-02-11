using System;
using System.Data.Entity;
using Techrepo.Data.Contracts;

namespace Techrepo.Data
{
    public class TechrepoUnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext context;

        public TechrepoUnitOfWork(DbContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
