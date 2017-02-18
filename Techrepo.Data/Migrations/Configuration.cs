namespace Techrepo.Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Techrepo.Data.TechrepoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TechrepoDbContext context)
        {
            if(context.Adverts.Any())
            {
                return;
            }

            IList<AdvertCategory> categories = new List<AdvertCategory>()
            {
                new AdvertCategory() {Id=1,Name="Laptop" },
                new AdvertCategory() {Id=2,Name="Laptop" },
                new AdvertCategory() {Id=3,Name="Laptop" },
                new AdvertCategory() {Id=4,Name="Laptop" },
                new AdvertCategory() {Id=5,Name="Laptop" }

            };

            IList<User> owners = new List<User>()
            {
                
                new User() {Email="osdjfngsd@abv.bg",Id="34",PhoneNumber="05346" },
                new User() {Email="osdjfngggsd@abv.bg",Id="3451",PhoneNumber="0534446" },
                new User() {Email="osdjfnjtgsd@abv.bg",Id="3455",PhoneNumber="0532246" },
                new User() {Email="osdjfftngsd@abv.bg",Id="145",PhoneNumber="0577346" },
                new User() {Email="osdjfngsdbdr@abv.bg",Id="45",PhoneNumber="0539946" }  
            };

            IList<Advert> adverts = new List<Advert>()
            {
                new Advert() {Id=3,Category=categories[0],CategoryId=categories[0].Id,
                    Delivery =Delivery.ByCustomer,Description="In perfect condition",Price=1200,Title="Acer V5",ProductState=ProductState.SecondHand,Owner=owners[0], OwnerId=int.Parse(owners[0].Id),OwnerEmail=owners[0].Email,OwnerPhone=owners[0].PhoneNumber},
                new Advert() {Id=3,Category=categories[1],CategoryId=categories[1].Id,
                    Delivery =Delivery.ByCustomer,Description="Perfect laptop",Price=2200,Title="Acer V7",ProductState=ProductState.SecondHand,Owner=owners[1], OwnerId=int.Parse(owners[1].Id),OwnerEmail=owners[1].Email,OwnerPhone=owners[1].PhoneNumber },
                new Advert() {Id=3,Category=categories[2],CategoryId=categories[2].Id,
                    Delivery =Delivery.ByCustomer,Description="No problems with the laptop",Price=1250,Title="Acer V3",ProductState=ProductState.SecondHand,Owner=owners[2], OwnerId=int.Parse(owners[2].Id),OwnerEmail=owners[2].Email,OwnerPhone=owners[2].PhoneNumber},
                new Advert() {Id=3,Category=categories[3],CategoryId=categories[3].Id,
                    Delivery =Delivery.ByCustomer,Description="Almost new laptop",Price=1290,Title="Acer V5-591G",ProductState=ProductState.SecondHand,Owner=owners[3], OwnerId=int.Parse(owners[3].Id),OwnerEmail=owners[3].Email,OwnerPhone=owners[3].PhoneNumber },
                new Advert() {Id=3,Category=categories[4],CategoryId=categories[4].Id,
                    Delivery =Delivery.ByCustomer,Description="Really good laptop",Price=900,Title="HP G3",ProductState=ProductState.SecondHand,Owner=owners[4], OwnerId=int.Parse(owners[4].Id),OwnerEmail=owners[4].Email,OwnerPhone=owners[4].PhoneNumber},
            };
            context.Adverts.AddOrUpdate(adverts.ToArray());

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
