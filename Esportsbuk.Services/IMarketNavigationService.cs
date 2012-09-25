using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Esportsbuk.Services.Values;

namespace Esportsbuk.Services
{
    public interface IMarketNavigationService 
    {
        IEnumerable<NavCategoryValue> GetPrematchMarketNavigation();
    }
}
