namespace EventsApp.Models.DAT;

public partial class Event
{
    public long EventId { get; set; }

    public string EventName { get; set; } = null!;

    public string? EventDesc { get; set; }

    public long? EventCost { get; set; }

    public DateTime? EventStart { get; set; }

    public DateTime? EventEnd { get; set; }
}
