using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Services.Values;
using System.Linq.Expressions;
using MarketProvider.Domain.Entities;

namespace MarketProvider.Services
{
    public interface IPrematchMarketService
    {
        IEnumerable<MarketValue> QueryMarkets(Func<MarketValue, bool> filter);
    }
}
