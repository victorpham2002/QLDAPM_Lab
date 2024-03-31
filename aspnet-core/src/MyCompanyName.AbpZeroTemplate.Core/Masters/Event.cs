using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Masters
{
    public class Event : Entity<int>, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
