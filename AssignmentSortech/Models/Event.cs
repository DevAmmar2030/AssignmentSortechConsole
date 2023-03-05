using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSortech.Models
{
    public class Event
    {
        public string Id { get; set; } = null!;

        [Required]
        public string? Summary { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public EventDateTime? Start { get; set; }
        [Required]
        public EventDateTime? End { get; set; }
        public bool SendNotifications { get; set; }
    }

    public class EventDateTime
    {
        public DateTime DateTime { get; set; }
        public string? TimeZone { get; set; }
    }
}
