using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class DatEvent
{
    public long Eventid { get; set; }

    public string Eventname { get; set; } = null!;

    public string? Eventdesc { get; set; }

    public long? Eventcost { get; set; }

    public DateTime? Eventstart { get; set; }

    public DateTime? Eventend { get; set; }
}
