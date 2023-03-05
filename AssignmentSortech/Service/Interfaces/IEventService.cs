using AssignmentSortech.Dto;
using AssignmentSortech.Enum;
using AssignmentSortech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSortech.Service.Interfaces
{
    public interface IEventService
    {
        Task<ValidationResult> CreateEvent(EventDto calendarEvent);
        Task<List<EventDto>> GetAllEvents();
        Task<EventDto> GetEventById(string id);
        Task<ValidationResult> RemoveEvent(string id);
    }
}
