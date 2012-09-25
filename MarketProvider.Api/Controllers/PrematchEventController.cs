using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarketProvider.Services;
using MarketProvider.Api.ViewModels;
using AutoMapper;

namespace MarketProvider.Api.Controllers
{
    public class PrematchEventController : ApiController
    {
        private readonly IPrematchEventService _service;

        public PrematchEventController(IPrematchEventService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<EventViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<EventViewModel>>(_service.GetAll());
        }

        
        [HttpGet]
        public EventViewModel Get(int id)
        {
            return Mapper.Map<EventViewModel>(_service.Get(id));
        }
    }
}
