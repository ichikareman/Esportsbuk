using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarketProvider.Services;
using MarketProvider.Api.ViewModels;

namespace MarketProvider.Api.Controllers
{
    public class PrematchMarketController : ApiController
    {
        private readonly IPrematchMarketService _service;

        public PrematchMarketController(IPrematchMarketService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<MarketViewModel> GetEventMarketsBySubCatIds(int[] subCatIds)
        {
            var markets = _service.QueryMarkets(m => subCatIds.Contains(m.Event.SubCategory.Id));

            return AutoMapper.Mapper.Map<List<MarketViewModel>>(markets);
        }
    }
}
