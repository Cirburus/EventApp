using EventsApp.Models.DAT;

namespace EventsApp.Models.MAP;

public partial class EventTeamUser
{
    public long? EventId { get; set; }

    public long? TeamId { get; set; }

    public long? UserId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Team? Team { get; set; }

    public virtual User? User { get; set; }
}
