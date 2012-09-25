using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Esportsbuk.Services;
using Esportsbuk.Services.Implementations;
using Esportsbuk.Api.ViewModels;
using AutoMapper;

namespace Esportsbuk.Api.Controllers
{
    public class PrematchMarketController : ApiController
    {
        private IPrematchMarketService _service;

        public PrematchMarketController()
        {
            _service = new PrematchMarketService();
        }

        [HttpGet]
        public IEnumerable<MarketViewModel> GetEventMarketsBySubCategoryIds(int[] subCatIds)
        {
            var valueList = _service.GetMarketsBySubCategoryIds(subCatIds);
            var viewModelList = Mapper.Map<IEnumerable<MarketViewModel>>(valueList);

            return viewModelList;
        }
    }
}
