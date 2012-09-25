using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProvider.Domain.Entities
{
    public class SubCategoryEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
