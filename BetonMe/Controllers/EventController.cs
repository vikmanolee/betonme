using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetonMe.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BetonMe.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public ViewResult List()
        {
            return View(_eventRepository.AllEvents);
        }

        public IActionResult Details(int id)
        {
            var @event = _eventRepository.GetEventById(id);
            if (@event == null)
                return NotFound();

            return View(@event);
        }
    }
}
