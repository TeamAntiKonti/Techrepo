﻿using System.Linq;
namespace Techrepo.Repositories.Contracts
{

    public interface IRepository<T>
    where T : class
    {
        IQueryable<T> Entities { get; }

        IQueryable<T> All();

        T GetById(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);

        void Detach(T entity);
    }

}