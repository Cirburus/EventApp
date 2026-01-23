namespace EventsApp.Models.DAT;

public partial class User
{
    public long UserId { get; set; }

    public string? FName { get; set; }

    public string LName { get; set; } = null!;
}
