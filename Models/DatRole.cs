using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class DatRole
{
    public long Roleid { get; set; }

    public string Rolename { get; set; } = null!;

    public string? Roledesc { get; set; }
}
