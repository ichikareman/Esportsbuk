using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Services.Values;

namespace MarketProvider.Services
{
    public interface ISubCategoryService
    {
        IEnumerable<SubCategoryValue> GetSubCategories(bool withActiveMarketOnly);
    }
}
