using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketProvider.Api.ViewModels
{
    public class MarketViewModel
    {
        public int Id { get; set; }

        public EventViewModel Event { get; set; }

        public string MarketGroupName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<MarketSelectionViewModel> MarketSelections { get; set; }
    }
}