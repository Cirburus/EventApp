namespace EventsApp.Models.DAT;

public partial class SideEvent
{
    public long SideEventId { get; set; }

    public string SideEventName { get; set; } = null!;

    public string? SideEventDesc { get; set; }

    public long? SideEventCost { get; set; }
}
