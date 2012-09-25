using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http.Formatting;

namespace Esportsbuk.Api.App_Start
{
    public class FormatConfig
    {
        public static void RegisterFormats(MediaTypeFormatterCollection formatting)
        {
            formatting.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
            formatting.JsonFormatter.AddQueryStringMapping("format", "json", "application/json");
        }
    }
}