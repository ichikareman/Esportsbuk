using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketProvider.Domain.Configurations
{
    public class EventEntityConfig : EntityTypeConfiguration<EventEntity>
    {
        public EventEntityConfig()
        {
            ToTable("tbl_event");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name).HasColumnName("Name").IsRequired();
            Property(e => e.StartDate).HasColumnName("StartDate");
            Property(e => e.EndDate).HasColumnName("EndDate");
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.Id);
            HasRequired(e => e.SubCategory).WithOptional().Map(m => m.MapKey("SuCategoryId"));
        }

    }
}
