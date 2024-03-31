using Abp.Application.Services;
using MyCompanyName.AbpZeroTemplate.Masters.Events.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Masters.Events
{
    public interface IEventAppService : IApplicationService
    {
        Task<IEnumerable<EventOutput>> GetEvents();
        Task<EventOutput> GetEvent(int id);
        Task<EventOutput> CreateEvent(CreateEventInput eventInput);        
        
    }
}
