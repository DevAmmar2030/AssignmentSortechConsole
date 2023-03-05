using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSortech.Dto
{
    public class EventDto
    {
        public string? Id { get; set; }
        public string Summary { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string StartDateTime { get; set; } = null!;
        public string EndDateTime { get; set; } = null!;

    }
}
