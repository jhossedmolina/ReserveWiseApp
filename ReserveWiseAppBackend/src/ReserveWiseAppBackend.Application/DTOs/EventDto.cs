using ReserveWiseAppBackend.Domain.Enums;

namespace ReserveWiseAppBackend.Application.DTOs
{
    public class EventDto
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
