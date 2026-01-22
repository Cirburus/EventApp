using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class DatSideevent
{
    public long Sideeventid { get; set; }

    public string Sideeventname { get; set; } = null!;

    public string? Sideeventdesc { get; set; }

    public long? Sideeventcost { get; set; }
}
