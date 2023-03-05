using AssignmentSortech.Dto;
using AssignmentSortech.Service.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentSortech.Enum;

namespace AssignmentSortech.View
{
    public class EventsView
    {
        private readonly IEventService _eventService;

        public EventsView(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async void createEvent()
        {
            Console.WriteLine("Summary :");
            var Summary = Console.ReadLine();
            Console.WriteLine("Description :");
            var Description = Console.ReadLine();
            Console.WriteLine("StartDateTime :");
            var StartDateTime = Console.ReadLine();
            Console.WriteLine("EndDateTime :");
            var EndDateTime = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(Summary) 
                && !string.IsNullOrWhiteSpace(Description) 
                && !string.IsNullOrWhiteSpace(StartDateTime)
                && !string.IsNullOrWhiteSpace(EndDateTime))
            {
                EventDto createEventDto = new EventDto
                {
                    Summary = Summary,
                    Description = Description,
                    EndDateTime = EndDateTime,
                    StartDateTime = StartDateTime,
                };

                var result = await _eventService.CreateEvent(createEventDto);

                Console.WriteLine("-------^^-----^^^------^^^^^--------^^^^^------------");
                Console.WriteLine("------ CREATED ------");
               
                Console.WriteLine("Result :" + result);
            }
            else
                Console.WriteLine("Data Is Required !!!");
        }

        public async void GetAllEvents()
        {
            var result =await _eventService.GetAllEvents();

            foreach (var item in result)
            {
                Console.WriteLine("Event Id For Get :" + item.Id);
                Console.WriteLine("Event Title :" + item.Summary);
                Console.WriteLine("Sart Date Time:" + item.StartDateTime);
                Console.WriteLine("End Date Time:" + item.EndDateTime);

                Console.WriteLine("----------------END LIST----------------"); 
                Console.WriteLine("----------------------------------------");
            }
        }

        public async void GetEventById()
        {
            Console.WriteLine("Event Id :");
            var eventId = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(eventId))
            {
                var result = await _eventService.GetEventById(eventId);
                if (result != null)
                {
                    Console.WriteLine("Event Title :" + result.Summary);
                    Console.WriteLine("Sart Date Time:" + result.StartDateTime);
                    Console.WriteLine("End Date Time:" + result.EndDateTime);
                    Console.WriteLine("------------ GET EVENT --------------");
                }
                Console.WriteLine("------------ NOT FOUND --------------");
            }
            else
                Console.WriteLine("Event Id Is Required !!!");

        }

        public async void RemoveEvent()
        {
            Console.WriteLine("Event Id :");
            var eventId = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(eventId))
            {
                var result = await _eventService.RemoveEvent(eventId);
                if (result == ValidationResult.Success)
                {
                    Console.WriteLine("------------"+ result + " --------------");
                    Console.WriteLine("------------REMOVE EVENT --------------");
                }
                else
                    Console.WriteLine("Event Id Is Required !!!");
            }
            else
                Console.WriteLine("REQUEST FAILED !!!");
        }
    }
}
