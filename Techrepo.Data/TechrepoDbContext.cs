using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Techrepo.Models;

namespace Techrepo.Data
{
    public class TechrepoDbContext : IdentityDbContext<User>, ITechrepoDbContext
    {
        public TechrepoDbContext()
            : base("Techrepo")
        {
        }

        public IDbSet<AdvertCategory> AdvertCategories { get; set; }
        public IDbSet<Advert> Adverts { get; set; }

        public IDbSet<City> Cities { get; set; }

        public static TechrepoDbContext Create()
        {
            return new TechrepoDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(user => user.Favourites).WithMany(a => a.Subscribers);
            //modelBuilder.Entity<User>().HasMany(user => user.MyAdverts).WithMany();        

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            base.OnModelCreating(modelBuilder);
        }
    }
}
