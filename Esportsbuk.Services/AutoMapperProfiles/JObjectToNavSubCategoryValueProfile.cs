using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Newtonsoft.Json.Linq;
using Esportsbuk.Services.Values;

namespace Esportsbuk.Services.AutoMapperProfiles
{
    public class JObjectToNavSubCategoryValueProfile : Profile
    {
        public JObjectToNavSubCategoryValueProfile()
        {
            Mapper.CreateMap<JObject, NavSubCategoryValue>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => (int)s["Id"]))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => (string)s["Name"]));
        }
    }
}
