using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Esportsbuk.Api.ViewModels;
using Esportsbuk.Services.Values;

namespace Esportsbuk.Api.AutoMapperProfiles
{
    public class MarketSelectionValueToMarketSelectionViewModelProfile : Profile
    {
        public MarketSelectionValueToMarketSelectionViewModelProfile()
        {
            Mapper.CreateMap<MarketSelectionValue, MarketSelectionViewModel>();
        }
    }
}