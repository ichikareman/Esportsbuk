using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Esportsbuk.Api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public Newtonsoft.Json.Linq.JArray Get()
        {
            string endpoint = "http://localhost:2838/api/Prematchmarket/GetPrematchEventMarketsByDateRange?startDate=2012/09/15&endDate=1";
            HttpClient x = new HttpClient();



            var sample = x.GetAsync(endpoint).Result;
            if (sample.IsSuccessStatusCode)
            {
                var result = sample.Content.ReadAsAsync<Newtonsoft.Json.Linq.JArray>().Result;            


            }


            return null;
            
            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}