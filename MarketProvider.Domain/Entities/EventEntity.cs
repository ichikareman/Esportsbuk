using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProvider.Domain.Entities
{
    public class EventEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SubCategoryEntity SubCategory { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
