namespace practice_prototype.Models;

public class Ticket
{
    public int Id { get; set; }
    public int ScreeningId { get; set; }
    public int Seat { get; set; }
    public decimal Price { get; set; }
}