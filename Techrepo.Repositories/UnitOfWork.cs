using System.Data.Entity;
using Techrepo.Repositories.Contracts;

namespace Techrepo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
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
