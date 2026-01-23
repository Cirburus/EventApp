using EventsApp.Models.DAT;

namespace EventsApp.Models.MAP;

public partial class EventSideEvent
{
    public long? EventId { get; set; }

    public long? SideEventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual SideEvent? SideEvent { get; set; }
}
