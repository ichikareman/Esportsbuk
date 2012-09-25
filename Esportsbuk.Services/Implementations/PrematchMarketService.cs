using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Esportsbuk.Services.Values;

namespace Esportsbuk.Services.Implementations
{
    public class PrematchMarketService : IPrematchMarketService
    {
        private readonly HttpClient _client;

        public PrematchMarketService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:2838/api/");
        }

        public IEnumerable<MarketValue> GetMarketsBySubCategoryIds(int[] subCatIds)
        {
            string getUrl = @"PrematchMarket/GetEventMarketsBySubCatIds/1,2,3,4";

            var result = _client.GetAsync(getUrl).Result;

            if (result.IsSuccessStatusCode)
            {
                return result.Content.ReadAsAsync<IEnumerable<MarketValue>>().Result;
            }

            return null;
        }
    }
}
