using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esportsbuk.Services.Values
{
    public class MarketValue
    {
        public int Id { get; set; }

        public EventValue Event { get; set; }

        public string MarketGroupName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<MarketSelectionValue> MarketSelections { get; set; }
    }
}
