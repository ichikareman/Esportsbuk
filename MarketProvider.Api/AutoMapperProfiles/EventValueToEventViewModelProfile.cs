using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarketProvider.Services.Values;
using MarketProvider.Api.ViewModels;

namespace MarketProvider.Api.AutoMapperProfiles
{
    public class EventValueToEventViewModelProfile : Profile
    {
        public EventValueToEventViewModelProfile()
        {
            Mapper.CreateMap<EventValue, EventViewModel>();
        }
    }
}