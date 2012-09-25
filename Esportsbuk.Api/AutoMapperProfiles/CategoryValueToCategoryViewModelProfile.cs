using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Esportsbuk.Services.Values;
using Esportsbuk.Api.ViewModels;

namespace Esportsbuk.Api.AutoMapperProfiles
{
    public class CategoryValueToCategoryViewModelProfile : Profile
    {
        public CategoryValueToCategoryViewModelProfile()
        {
            Mapper.CreateMap<CategoryValue, CategoryViewModel>();
        }
    }
}