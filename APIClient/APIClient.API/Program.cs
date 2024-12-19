using APIClient.API.Services;
using APIClient.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext configuration
builder.Services.AddDbContext<ApiClientContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("ClientContext")));

// CORS configuration
var origins = builder.Configuration.GetSection("AppClientUrl").Value;
if (string.IsNullOrEmpty(origins))
{
    throw new Exception("AppClientUrl is not configured");
}
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "app-client",
        policyBuilder =>
        {
            policyBuilder.WithOrigins(origins)
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Services configuration
builder.Services.AddScoped<ClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS policy configuration
app.UseCors("app-client");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();