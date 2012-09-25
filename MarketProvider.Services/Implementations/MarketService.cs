using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain;

namespace MarketProvider.Services.Implementations
{
    public class MarketService : IMarketService
    {
        private readonly IRepository<MarketEntity> _repository;

        public MarketService(IRepository<MarketEntity> repository)
        {
            _repository = repository;
        }
    }
}
