using EventsApp.Models.DAT;

namespace EventsApp.Models.MAP;

public partial class EventLocation
{
    public long? EventId { get; set; }

    public long? LocationId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Location? Location { get; set; }
}
