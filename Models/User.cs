namespace practice_prototype.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Role { get; set; } = "User";
    public ICollection<Ticket>? Tickets { get; set; }
}
