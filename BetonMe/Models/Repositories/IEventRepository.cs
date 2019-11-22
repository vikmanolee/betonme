using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    interface IEventRepository
    {
        IEnumerable<Event> AllEvents { get; }
        Event GetEventById(int eventId);
    }
}
