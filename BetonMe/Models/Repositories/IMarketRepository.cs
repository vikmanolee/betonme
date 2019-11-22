using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    interface IMarketRepository
    {
        IEnumerable<Market> AllMarkets { get; }
        Market GetMarketById(int marketId);
    }
}
