using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketProvider.Domain.Configurations
{
    public class SubCategoryEntityConfig : EntityTypeConfiguration<SubCategoryEntity>
    {
        public SubCategoryEntityConfig()
        {
            ToTable("tbl_subCategory");
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
            HasRequired(e => e.Category).WithRequiredDependent().Map(m => m.MapKey("CategoryId"));
        }

       
    }
}
