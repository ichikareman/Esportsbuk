using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MarketProvider.Domain.Entities;

namespace MarketProvider.Domain
{
    public interface ISportsbookDbContext
    {
        IDbSet<MarketEntity> MarketEntities { get; set; }
        IDbSet<EventEntity> EventEntities { get; set; }
    }
}
