using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketProvider.Api.ViewModels
{
    public class NavCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<NavSubCategoryViewModel> SubCategories { get; set; }
    }
}