using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain;
using MarketProvider.Services.Extensions;
using MarketProvider.Services.Values;
using System.Collections;

namespace MarketProvider.Services.Implementations
{
    public class MarketNavigationService : IMarketNavigationService
    {
        private readonly IRepository<SubCategoryEntity> _subCatRepo;
        private readonly IRepository<MarketEntity> _marketRepo;

        public MarketNavigationService(IRepository<SubCategoryEntity> subCatRepo, IRepository<MarketEntity> marketRepo)
        {
            _subCatRepo = subCatRepo;
            _marketRepo = marketRepo;
        }

        public IEnumerable<NavCategoryValue> GetPrematchMarketNavigationMenu()
        {
            // TODO: Improve this query and check with the profiler
            var subCats = _marketRepo.Query(m => m.Event, m => m.Event.SubCategory, m => m.Event.SubCategory.Category)
                .Where(m => m.EndDate > DateTime.Now)
                .DistinctBy(m => m.Event.SubCategory.Id).AsEnumerable();

            List<NavCategoryValue> nav = new List<NavCategoryValue>();

            for (int x = 0; x < subCats.Count(); x++)
            {
                var item = subCats.ElementAt(x);
                var subCat = new NavSubCategoryValue(){
                    Id = item.Event.SubCategory.Id,
                    Name = item.Event.SubCategory.Name
                };

                var cat = nav.Find((z) => z.Id == item.Event.SubCategory.Category.Id);

                if (cat != null)
                {
                    cat.SubCategories.Add(subCat);
                }
                else
                {
                    cat = new NavCategoryValue()
                    {
                        Id = item.Event.SubCategory.Category.Id,
                        Name = item.Event.SubCategory.Category.Name,
                    };

                    cat.SubCategories = new List<NavSubCategoryValue>();
                    cat.SubCategories.Add(subCat);
                    nav.Add(cat);
                }
            }

            return nav;
        }
    }
}
