using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketProvider.Services.Values;

namespace MarketProvider.Services
{
    public interface IPrematchEventService
    {
        IEnumerable<EventValue> GetAll();

        EventValue Get(int id);
    }
}
