using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Esportsbuk.Services.Values;
using AutoMapper;

namespace Esportsbuk.Services.Implementations
{
    public class MarketNavigationService : IMarketNavigationService
    {
        private readonly HttpClient _client;

        public MarketNavigationService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:2838/api/");
        }

        public IEnumerable<Values.NavCategoryValue> GetPrematchMarketNavigation()
        {
            string getUrl = @"Navigation/GetPrematchMarketNavigation";

            var result =  _client.GetAsync(getUrl).Result;

            if (result.IsSuccessStatusCode)
            {
                return result.Content.ReadAsAsync<IEnumerable<NavCategoryValue>>().Result;
            }

            return null;
        }
    }
}
