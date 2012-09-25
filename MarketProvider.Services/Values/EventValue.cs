using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProvider.Services.Values
{
    public class EventValue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SubCategoryValue SubCategory { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
