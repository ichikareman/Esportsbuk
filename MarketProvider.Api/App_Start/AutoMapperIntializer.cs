using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarketProvider.Services.AutoMapperProfiles;
using MarketProvider.Api.AutoMapperProfiles;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MarketProvider.Api.App_Start.AutoMapperIntializer), "Initialize")]

namespace MarketProvider.Api.App_Start
{
    public static class AutoMapperIntializer
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new EventEntityToEventValueProfile());
            Mapper.AddProfile(new EventValueToEventViewModelProfile());

            Mapper.AddProfile(new CategoryEntityToCategoryValueProfile());
            Mapper.AddProfile(new CategoryValueToCategoryViewModelProfile());

            Mapper.AddProfile(new SubCategoryEntityToSubCategoryValueProfile());
            Mapper.AddProfile(new SubCategoryValueToSubCategoryValueModelProfile());

            Mapper.AddProfile(new NavCategoryValueToNavCategoryViewModelProfile());
            Mapper.AddProfile(new NavSubCategoryValueToNavSubCategoryViewModelProfile());

            Mapper.AddProfile(new MarketEntityToMarketValueProfile());
            Mapper.AddProfile(new MarketSelectionEntityToMarketSelectionValueProfile());

            Mapper.AddProfile(new MarketSelectionValueToMarketSelectionViewModelProfile());
            Mapper.AddProfile(new MarketValueToMarketViewModelProfile());
        }
    }
}