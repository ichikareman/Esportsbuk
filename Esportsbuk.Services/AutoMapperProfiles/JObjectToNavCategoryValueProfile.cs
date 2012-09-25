using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Esportsbuk.Services.Values;

namespace Esportsbuk.Services.AutoMapperProfiles
{
    public class JObjectToNavCategoryValueProfile : Profile
    {
        public JObjectToNavCategoryValueProfile()
        {
            Mapper.CreateMap<Newtonsoft.Json.Linq.JObject, NavCategoryValue>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => (int)s["Id"]))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => (string)s["Name"]))
                .ForMember(d => d.SubCategories, opt => opt.MapFrom(s => Mapper.Map<IEnumerable<NavSubCategoryValue>>(s["SubCategories"])));
        }
    }
}
