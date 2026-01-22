using System;
using System.Collections.Generic;

namespace EventsApp.Models;

public partial class DatLocation
{
    public long Locationid { get; set; }

    public string? Locationname { get; set; }

    public string? Locationaddress1 { get; set; }

    public string? Locationaddress2 { get; set; }

    public string? Locationcity { get; set; }

    public string? Locationstateprov { get; set; }

    public string? Locationpostcode { get; set; }

    public string? Locationremote { get; set; }

    public string? Locationemail { get; set; }

    public string? Locationphone { get; set; }
}
