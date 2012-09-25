using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarketProvider.Services.Values;
using MarketProvider.Api.ViewModels;

namespace MarketProvider.Api.AutoMapperProfiles
{
    public class NavCategoryValueToNavCategoryViewModelProfile : Profile
    {
        public NavCategoryValueToNavCategoryViewModelProfile()
        {
            Mapper.CreateMap<NavCategoryValue, NavCategoryViewModel>();
        }
    }
}