using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Thinktecture.IdentityModel.Http.Cors.WebApi;

namespace MarketProvider.Api.App_Start
{
    public static class CorsConfig
    {
        public static void RegisterCors(HttpConfiguration httpConfig)
        {
            WebApiCorsConfiguration corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(httpConfig);

            corsConfig.ForResources("Navigation")
                .ForOrigins("http://localhost:9240")
                .AllowAll();
        }
    }
}