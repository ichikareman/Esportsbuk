﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketProvider.Api.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SubCategoryViewModel SubCategory {get; set;}
    }
}