using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    public class MockEventRepository : IEventRepository
    {
        public IEnumerable<Event> AllEvents =>
        new List<Event> 
            {
                new Event { Id = 1, Name = "Event One"},
                new Event { Id = 2, Name = "Event Two"}
            };

        public Event GetEventById(int eventId)
        {
            return AllEvents.FirstOrDefault(e => e.Id == eventId);
        }
    }
}
