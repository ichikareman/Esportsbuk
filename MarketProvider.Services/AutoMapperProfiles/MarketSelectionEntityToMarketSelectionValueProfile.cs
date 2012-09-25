using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MarketProvider.Domain.Entities;
using MarketProvider.Services.Values;

namespace MarketProvider.Services.AutoMapperProfiles
{
    public class MarketSelectionEntityToMarketSelectionValueProfile : Profile
    {
        public MarketSelectionEntityToMarketSelectionValueProfile()
        {
            Mapper.CreateMap<MarketSelectionEntity, MarketSelectionValue>();
        }
    }
}
