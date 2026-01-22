using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class MapEventlocation
{
    public long? Eventid { get; set; }

    public long? Locationid { get; set; }

    public virtual DatEvent? Event { get; set; }

    public virtual DatLocation? Location { get; set; }
}
