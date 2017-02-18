using System;
using Techrepo.Data.Contracts;

namespace Techrepo.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITechrepoDbContext dbContext;
        public UnitOfWork(ITechrepoDbContext context)
        {
            // TODO: Global validations
            if(context == null)
            {
                throw new ArgumentNullException("Context cannot be null");
            }
            this.dbContext = context;
        }
        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
