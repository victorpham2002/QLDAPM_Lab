using Abp.Domain.Repositories;
using MyCompanyName.AbpZeroTemplate.Masters.Events.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompanyName.AbpZeroTemplate.Masters;

namespace MyCompanyName.AbpZeroTemplate.Masters.Events
{
    public class EventAppService : AbpZeroTemplateAppServiceBase, IEventAppService
    {
        private readonly IRepository<Event, int> _eventRepository;

        public EventAppService(IRepository<Event, int> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<EventOutput> CreateEvent(CreateEventInput eventInput)
        {
            var eventEntity = ObjectMapper.Map<Event>(eventInput);
            eventEntity = await _eventRepository.InsertAsync(eventEntity);
            return ObjectMapper.Map<EventOutput>(eventEntity);
        }

        public async Task<EventOutput> GetEvent(int id)
        {
            var eventEntity = await _eventRepository.FirstOrDefaultAsync(id);
            return ObjectMapper.Map<EventOutput>(eventEntity);
        }

        public async Task<IEnumerable<EventOutput>> GetEvents()
        {
            var events = await _eventRepository.GetAllListAsync();
            return events.Select(e => ObjectMapper.Map<EventOutput>(e));
        }

    }
}
