using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class MapEventsideeventuser
{
    public long? Eventid { get; set; }

    public long? Sideeventid { get; set; }

    public long? Userid { get; set; }

    public virtual DatEvent? Event { get; set; }

    public virtual DatSideevent? Sideevent { get; set; }

    public virtual DatUser? User { get; set; }
}
