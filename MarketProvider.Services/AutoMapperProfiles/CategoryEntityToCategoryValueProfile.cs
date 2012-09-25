using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MarketProvider.Services.Values;
using MarketProvider.Domain.Entities;
using MarketProvider.Services.QueryHelper;

namespace MarketProvider.Services.AutoMapperProfiles
{
    public class CategoryEntityToCategoryValueProfile : Profile
    {
        public CategoryEntityToCategoryValueProfile()
        {
            Mapper.CreateMap<CategoryEntity, CategoryValue>();
            //Mapper.CreateMap<IGrouping<EventEntity, MarketEntity>, IGrouping<EventValue, MarketValue>>();
            //Mapper.CreateMap<List<IGrouping<EventEntity, MarketEntity>>, List<IGrouping<EventValue, MarketValue>>>();

            //Mapper.CreateMap<IGrouping<EventEntity, MarketEntity>, Grouping<EventValue, EventValue>>()
            //    .ForMember(d => d.Key, opt => opt.MapFrom(s => s.Key));
               

            //Mapper.CreateMap<IGrouping<CategoryEntity, IGrouping<SubCategoryEntity, IGrouping<EventEntity, MarketEntity>>>, IGrouping<CategoryValue, IGrouping<SubCategoryValue, IGrouping<EventValue, MarketValue>>>>();
            //Mapper.CreateMap<List<IGrouping<CategoryEntity, IGrouping<SubCategoryEntity, IGrouping<EventEntity, MarketEntity>>>>, List<IGrouping<CategoryValue, IGrouping<SubCategoryValue, IGrouping<EventValue, MarketValue>>>>>();
        }

        
    }
}
