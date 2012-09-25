using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MarketProvider.Domain;
using MarketProvider.Domain.Entities;
using System.Collections.ObjectModel;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MarketProvider.Api.App_Start.DbContextInitializer), "Initialize")]

namespace MarketProvider.Api.App_Start
{
    public static class DbContextInitializer
    {
        public static void Initialize()
        {
            Database.SetInitializer(new SportsbookDbContextInitializer());
        }
    }

    public class SportsbookDbContextInitializer : DropCreateDatabaseAlways<SportsbookDbContext>
    {
        protected override void Seed(SportsbookDbContext context)
        {

            // Categories
            string[] catNames = new string[]{"Football", "Basketball", "Ice Skating", "Baseball", "Badminton", "Swimming", "American Football", "Boxing", "Biking", "Running"};

            foreach (string catName in catNames)
            {
                var cat = new CategoryEntity()
                {
                    Name = catName
                };

                var subCat = new SubCategoryEntity()
                {
                    Name = "SubCat" + catName,
                    Category = cat
                };

                context.SubCategoryEntities.Add(subCat);
               
            }

            context.SaveChanges();

            // Events
            for (int x = 0; x < 10; x++)
            {
                var ev = new EventEntity()
                {
                    Name = "A" + x.ToString() + " - B" + x.ToString(),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.Add(TimeSpan.FromDays(1)),
                    SubCategory = context.SubCategoryEntities.ToList()[x]
                };

                var market = new MarketEntity()
                {
                    MarketGroupName = "Match Winner",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.Add(TimeSpan.FromDays(1)),
                    Event = ev,
                    MarketSelections = new Collection<MarketSelectionEntity>(){
                        new MarketSelectionEntity(){
                        Odds = 1.1,
                        DisplayName = "1"
                        },

                        new MarketSelectionEntity(){
                        Odds = 1.2,
                        DisplayName = "X"
                        },

                        new MarketSelectionEntity(){
                        Odds = 1.3,
                        DisplayName = "2"
                        },
                    }
                };

                context.MarketEntities.Add(market);

            }


            context.SaveChanges();
        }
    }
}