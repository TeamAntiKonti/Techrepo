using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Techrepo.Models;

namespace Techrepo.Data
{
    public interface ITechrepoDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<Advert> Adverts { get; set; }

        IDbSet<City> Cities { get; set; }

        IDbSet<AdvertCategory> AdvertCategories { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
