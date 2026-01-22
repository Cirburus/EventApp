using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class MapEventsideevent
{
    public long? Eventid { get; set; }

    public long? Sideeventid { get; set; }

    public virtual DatEvent? Event { get; set; }

    public virtual DatSideevent? Sideevent { get; set; }
}
