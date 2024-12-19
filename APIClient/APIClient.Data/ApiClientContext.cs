using APIClient.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APIClient.Data;

public class ApiClientContext(DbContextOptions<ApiClientContext> options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
}