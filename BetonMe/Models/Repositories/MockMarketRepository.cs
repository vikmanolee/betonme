using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    public class MockMarketRepository : IMarketRepository
    {
        private readonly IEventRepository _eventRepository = new MockEventRepository();

        public IEnumerable<Market> AllMarkets => 
            new List<Market>
            {
                new Market { Id = 1, Name = "Market One", Event = _eventRepository.GetEventById(1)},
                new Market { Id = 2, Name = "Market Two", Event = _eventRepository.GetEventById(1)},
                new Market { Id = 3, Name = "Market Three", Event = _eventRepository.GetEventById(2)}
            };

        public Market GetMarketById(int marketId)
        {
            return AllMarkets.FirstOrDefault(e => e.Id == marketId);
        }
    }
}
