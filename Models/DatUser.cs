using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventsApp.Models;

[Table("DatUser")]
public partial class DatUser
{
    [Key]
    public long Userid { get; set; }

    public string? Fname { get; set; }

    public string Lname { get; set; } = null!;
}
