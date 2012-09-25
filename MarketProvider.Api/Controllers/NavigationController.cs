using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MarketProvider.Services;
using MarketProvider.Api.ViewModels;
using AutoMapper;
using System.Net.Http;
using System.Net;
using MarketProvider.Api.Attributes;

namespace MarketProvider.Api.Controllers
{
    public class NavigationController : ApiController
    {
        private readonly IMarketNavigationService _service;

        public NavigationController(IMarketNavigationService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public HttpResponseMessage MarketNavigationMenu()
        {
            var viewModel = Mapper.Map<IEnumerable<NavCategoryViewModel>>(_service.GetPrematchMarketNavigationMenu());
            var response = Request.CreateResponse(HttpStatusCode.OK, viewModel);

            return response;
        }
    }
}