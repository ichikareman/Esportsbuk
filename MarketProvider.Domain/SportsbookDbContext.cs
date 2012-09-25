using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain.Configurations;

namespace MarketProvider.Domain
{
    public class SportsbookDbContext : DbContext, ISportsbookDbContext
    {
        public IDbSet<MarketEntity> MarketEntities { get; set; }
        public IDbSet<EventEntity> EventEntities { get; set; }
        public IDbSet<CategoryEntity> CategoryEntities { get; set; }
        public IDbSet<SubCategoryEntity> SubCategoryEntities { get; set; }

        public SportsbookDbContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventEntityConfig());
            modelBuilder.Configurations.Add(new MarketEntityConfig());
            modelBuilder.Configurations.Add(new CategoryEntityConfig());
            modelBuilder.Configurations.Add(new SubCategoryEntityConfig());
            modelBuilder.Configurations.Add(new MarketSelectionEntityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
