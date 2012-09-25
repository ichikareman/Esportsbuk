using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketProvider.Api.ViewModels;
using MarketProvider.Services.Values;
using AutoMapper;

namespace MarketProvider.Api.AutoMapperProfiles
{
    public class MarketValueToMarketViewModelProfile : Profile
    {
        public MarketValueToMarketViewModelProfile()
        {
            Mapper.CreateMap<MarketValue, MarketViewModel>();
        }
    }
}