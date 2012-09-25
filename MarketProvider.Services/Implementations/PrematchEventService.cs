using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain;
using MarketProvider.Services.Values;
using AutoMapper;

namespace MarketProvider.Services.Implementations
{
    public class PrematchEventService : IPrematchEventService
    {
        private readonly IRepository<EventEntity> _reposotory;

        public PrematchEventService(IRepository<EventEntity> reposotory)
        {
            _reposotory = reposotory;
        }

        public IEnumerable<EventValue> GetAll()
        {
            return Mapper.Map<IEnumerable<EventValue>>(_reposotory.Query().ToList());
        }

        public EventValue Get(int id)
        {
            return Mapper.Map<EventValue>(_reposotory.Get(id));
        }
    }
}
