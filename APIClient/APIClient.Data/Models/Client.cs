namespace APIClient.Data.Models;

public class Client
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Country { get; set; }
    public required string Phone { get; set; }
}