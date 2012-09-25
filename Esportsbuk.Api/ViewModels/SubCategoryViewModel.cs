using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esportsbuk.Api.ViewModels
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}
