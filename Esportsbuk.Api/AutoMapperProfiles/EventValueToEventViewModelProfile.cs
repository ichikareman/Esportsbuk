using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Esportsbuk.Services.Values;
using Esportsbuk.Api.ViewModels;

namespace Esportsbuk.Api.AutoMapperProfiles
{
    public class EventValueToEventViewModelProfile : Profile
    {
        public EventValueToEventViewModelProfile()
        {
            Mapper.CreateMap<EventValue, EventViewModel>();
        }
    }
}