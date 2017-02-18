namespace Techrepo.Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<TechrepoDbContext>
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

            // Add or change the id of a user to 34 to seed properly the ads
            IList<User> owners = new List<User>()
            {

                new User() {FirstName="gosho", LastName="gosho", UserName="gosho", Email="osdjfngsd@abv.bg", Id="34",PhoneNumber="05346" },
            };

            IList<AdvertCategory> categories = new List<AdvertCategory>()
            {
                new AdvertCategory() {Id=1,Name="Laptop" }

            };

            context.AdvertCategories.Add(categories[0]);

            context.Adverts.Add(new Advert()
            {
                Id = 3,
                Category = categories[0],
                CategoryId = categories[0].Id,
                Delivery = Delivery.ByCustomer.ToString(),
                Description = "In perfect condition",
                Price = 1200,
                Title = "Acer V5",
                ProductState = ProductState.SecondHand.ToString(),
                Owner = owners[0],
                OwnerId = owners[0].Id,
                OwnerEmail = owners[0].Email,
                OwnerPhone = owners[0].PhoneNumber
            });

            context.SaveChanges(); 
        }
    }
}
