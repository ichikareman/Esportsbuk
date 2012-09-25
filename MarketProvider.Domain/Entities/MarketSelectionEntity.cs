using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProvider.Domain.Entities
{
    public class MarketSelectionEntity
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public double Odds { get; set; }
    }
}
