using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using MarketProvider.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketProvider.Domain.Configurations
{
    public class MarketEntityConfig : EntityTypeConfiguration<MarketEntity>
    {
        public MarketEntityConfig()
        {
            ToTable("tbl_market");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.StartDate).HasColumnName("StartDate");
            Property(e => e.EndDate).HasColumnName("EndDate");
        }

        private void RelationshipConfig()
        {
            HasRequired(e => e.Event).WithOptional().Map(m => m.MapKey("EventId"));
            HasMany(e => e.MarketSelections).WithRequired().Map(m => m.MapKey("MarketId"));
        }
    }
}
