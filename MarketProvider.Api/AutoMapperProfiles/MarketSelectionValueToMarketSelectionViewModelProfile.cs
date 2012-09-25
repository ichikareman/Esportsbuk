using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarketProvider.Api.ViewModels;
using MarketProvider.Services.Values;

namespace MarketProvider.Api.AutoMapperProfiles
{
    public class MarketSelectionValueToMarketSelectionViewModelProfile : Profile
    {
        public MarketSelectionValueToMarketSelectionViewModelProfile()
        {
            Mapper.CreateMap<MarketSelectionValue, MarketSelectionViewModel>();
        }
    }
}