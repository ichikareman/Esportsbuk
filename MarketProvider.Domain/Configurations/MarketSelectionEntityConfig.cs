using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketProvider.Domain.Configurations
{
    public class MarketSelectionEntityConfig : EntityTypeConfiguration<MarketSelectionEntity>
    {
        public MarketSelectionEntityConfig()
        {
            ToTable("tbl_marketSelection");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.DisplayName).HasColumnName("DisplayName");
            Property(e => e.Odds).HasColumnName("Odds");
        }

        private void RelationshipConfig()
        {
            
        }
    }
}
