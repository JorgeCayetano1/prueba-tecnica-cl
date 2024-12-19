namespace APIClient.Shared.DTOs;

public class ClientDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Country { get; set; }
    public required string Phone { get; set; }
    public required int TotalCount { get; set; }
}