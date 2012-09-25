using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Esportsbuk.Services;
using Esportsbuk.Services.Implementations;
using Esportsbuk.Services.Values;
using Esportsbuk.Api.ViewModels;
using AutoMapper;

namespace Esportsbuk.Api.Controllers
{
    public class NavigationController : ApiController
    {
        private readonly IMarketNavigationService _service;

        public NavigationController()
        {
            _service = new MarketNavigationService();
        }

        [ActionName("Prematch")]
        [HttpGet]
        public IEnumerable<NavCategoryViewModel> GetPrematchNavigation()
        {
            var valueList = _service.GetPrematchMarketNavigation();
            var viewModelList = Mapper.Map<IEnumerable<NavCategoryViewModel>>(valueList);

            return viewModelList;
        }
    }
}
