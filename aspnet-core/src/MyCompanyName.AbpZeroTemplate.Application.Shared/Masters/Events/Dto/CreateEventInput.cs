using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.Masters.Events.Dto
{
    public class CreateEventInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
