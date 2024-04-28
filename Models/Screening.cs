namespace practice_prototype.Models;

public class Screening
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int HallId { get; set; }
    public DateTime Time { get; set; }
}
