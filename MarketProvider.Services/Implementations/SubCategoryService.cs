using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Services.Values;
using MarketProvider.Domain;
using MarketProvider.Domain.Entities;
using AutoMapper;

namespace MarketProvider.Services.Implementations
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IRepository<SubCategoryEntity> _repository;

        public SubCategoryService(IRepository<SubCategoryEntity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SubCategoryValue> GetSubCategories(bool withActiveMarketOnly)
        {
            return null;
        }
    }
}
