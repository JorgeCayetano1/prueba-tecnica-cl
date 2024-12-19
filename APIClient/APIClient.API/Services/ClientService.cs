using APIClient.Data;
using APIClient.Data.Models;
using APIClient.Shared.Common;
using APIClient.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APIClient.API.Services;

public class ClientService
{
    private readonly ApiClientContext _context;
    
    public ClientService(ApiClientContext context)
    {
        _context = context;
    }
    
    public async Task<ResponseModel<ResponsePagination<Client>>> GetClientsEf(GetClientDto dto)
    {
        var clients = await _context.Clients.Skip((dto.Page - 1) * dto.PageSize).Take(dto.PageSize).ToListAsync();
        var total = await _context.Clients.CountAsync();

        return new ResponseModel<ResponsePagination<Client>>
        {
            Success = true,
            Output = new ResponsePagination<Client>
            {
                Length = total,
                PageSize = dto.PageSize,
                Data = clients
            }
        };
    }
    
    public async Task<ResponseModel<ResponsePagination<Client>>> GetClientsSp(GetClientDto dto)
    {
        var clients = await _context.Database.SqlQueryRaw<ClientDto>("EXEC GetClients {0}, {1}", dto.Page, dto.PageSize).ToListAsync();
        if (clients.Count == 0) return new ResponseModel<ResponsePagination<Client>> { Success = false, Message = "No clients found" };
        var total = clients.FirstOrDefault()?.TotalCount ?? 0;

        return new ResponseModel<ResponsePagination<Client>>
        {
            Success = true,
            Output = new ResponsePagination<Client>
            {
                Length = total,
                PageSize = dto.PageSize,
                Data =  clients.Select(c => new Client
                {
                    Id = c.Id,
                    Name = c.Name,
                    Country = c.Country,
                    Phone = c.Phone
                }).ToList()
            }
        };
    }
}