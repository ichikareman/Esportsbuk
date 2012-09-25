using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Esportsbuk.Services.AutoMapperProfiles;
using Esportsbuk.Api.AutoMapperProfiles;

[assembly:WebActivator.PreApplicationStartMethod(typeof( Esportsbuk.Api.App_Start.AutoMapperInitializer), "Initialize")]

namespace Esportsbuk.Api.App_Start
{
    public static class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new NavCategoryValueToNavCategoryViewModelProfile());
            Mapper.AddProfile(new NavSubCategoryValueToNavSubCategoryViewModelProfile());
        }
    }
}