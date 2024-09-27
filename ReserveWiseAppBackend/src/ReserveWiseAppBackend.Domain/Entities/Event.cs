using ReserveWiseAppBackend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveWiseAppBackend.Domain.Entities
{
    public class Event
    {
        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime DateAndTime { get; set; }

        public string Location { get; set; } = null!;

        public string Capacity { get; set; } = null!;

        public Decimal Price { get; set; }

        public EventStatusEnum Status { get; set; }
    }
}
