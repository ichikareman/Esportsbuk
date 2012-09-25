using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProvider.Services.Values
{
    public class SubCategoryValue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CategoryValue Category { get; set; }
    }
}
