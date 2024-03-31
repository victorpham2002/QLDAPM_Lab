using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Masters.Events;
using MyCompanyName.AbpZeroTemplate.Masters.Events.Dto;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Web.Controllers
{
    public class EventController : AbpZeroTemplateControllerBase
    {
        private readonly IEventAppService _eventAppService;

        public EventController(IEventAppService eventAppService)
        {
            _eventAppService = eventAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var events = await _eventAppService.GetEvents();
            return View(events);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEventInput eventInput)
        {
            await _eventAppService.CreateEvent(eventInput);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var eventOutput = await _eventAppService.GetEvent(id);
            return View(eventOutput);
        }
    }
}
