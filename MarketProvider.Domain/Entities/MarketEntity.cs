using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace MarketProvider.Domain.Entities
{
    public class MarketEntity
    {
        public int Id { get; set; }

        public EventEntity Event { get; set; }

        public string MarketGroupName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Collection<MarketSelectionEntity> MarketSelections { get; set; }
    }
}
