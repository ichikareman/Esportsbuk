using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketProvider.Domain.Configurations
{
    public class CategoryEntityConfig : EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryEntityConfig()
        {
            ToTable("tbl_category");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name).HasColumnName("Name").IsRequired();
        }

        private void RelationshipConfig()
        {
            
        }
    }
}
