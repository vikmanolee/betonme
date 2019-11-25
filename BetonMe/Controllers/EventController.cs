using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetonMe.Models;
using BetonMe.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BetonMe.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMarketRepository _marketRepository;
        private readonly ISelectionRepository _selectionRepository;

        public EventController(IEventRepository eventRepository, IMarketRepository marketRepository, ISelectionRepository selectionRepository)
        {
            _eventRepository = eventRepository;
            _marketRepository = marketRepository;
            _selectionRepository = selectionRepository;
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

            @event.Markets = _marketRepository.AllMarkets.Where(m => m.Event.Id == id).ToList();
            @event.Markets.ForEach(m => m.Selections = _selectionRepository.AllSelections.Where(s => s.Market.Id == m.Id).ToList());

            return View(@event);
        }
    }
}
