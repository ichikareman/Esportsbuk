using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esportsbuk.Api.ViewModels
{
    public class MarketSelectionViewModel
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public double Odds { get; set; }
    }
}
