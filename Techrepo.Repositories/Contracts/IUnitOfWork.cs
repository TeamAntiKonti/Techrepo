using System;

namespace Techrepo.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
