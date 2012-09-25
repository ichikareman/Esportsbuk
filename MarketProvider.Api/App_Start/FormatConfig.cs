using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace MarketProvider.Api
{
    public static class FormatConfig
    {
        public static void RegisterFormats(MediaTypeFormatterCollection formatting)
        {
            formatting.JsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Include;
            formatting.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("format", "json", "application/json"));
        }
    }
}   