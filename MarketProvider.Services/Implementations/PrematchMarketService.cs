using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Services.Values;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain;
using AutoMapper;
using System.Linq.Expressions;

namespace MarketProvider.Services.Implementations
{
    public class PrematchMarketService : IPrematchMarketService
    {
        private readonly IRepository<MarketEntity> _marketRepo;

        public PrematchMarketService(IRepository<MarketEntity> marketRepo)
        {
            _marketRepo = marketRepo;
        }

        public IEnumerable<MarketValue> QueryMarkets(Func<MarketValue, bool> filter)
        {
            var startLimit = DateTime.Now;
            var endLimit = DateTime.Now.AddMonths(6);

            var marketEntityList = _marketRepo.Query(e => e.MarketSelections, e => e.Event, e => e.Event.SubCategory, e => e.Event.SubCategory.Category)
                .Where(m => (m.StartDate >= startLimit) && m.EndDate <= endLimit);
            
            var marketValueList = Mapper.Map<List<MarketValue>>(marketEntityList);

            if(filter != null){
                return marketValueList.Where(filter);
            }

            return marketValueList;
        }
    }
}
