
namespace practice_prototype.Models;

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public string Director { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Year { get; set; }
    public ICollection<Ticket>? Tickets { get; set; }
}