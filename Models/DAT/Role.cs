namespace EventsApp.Models.DAT;

public partial class Role
{
    public long RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDesc { get; set; }
}
