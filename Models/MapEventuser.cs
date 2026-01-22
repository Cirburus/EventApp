using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class MapEventuser
{
    public long? Eventid { get; set; }

    public long? Userid { get; set; }

    public virtual DatEvent? Event { get; set; }

    public virtual DatUser? User { get; set; }
}
