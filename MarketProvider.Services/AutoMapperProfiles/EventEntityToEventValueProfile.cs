using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MarketProvider.Services.Values;
using MarketProvider.Domain.Entities;

namespace MarketProvider.Services.AutoMapperProfiles
{
    public class EventEntityToEventValueProfile : Profile
    {
        public EventEntityToEventValueProfile()
        {
            Mapper.CreateMap<EventEntity, EventValue>();
        }
    }
}
