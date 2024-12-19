using APIClient.API.Services;
using APIClient.Shared.Common;
using APIClient.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIClient.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }
        
        [HttpGet("ef")]
        public async Task<IActionResult> GetClientsEf([FromQuery] GetClientDto requestDto)
        {
            var clients = await _clientService.GetClientsEf(requestDto);
            if (!clients.Success) return BadRequest(clients.Message);
            
            return Ok(clients);
        }
        
        [HttpGet("sp")]
        public async Task<IActionResult> GetClientsSp([FromQuery] GetClientDto requestDto)
        {
            var clients = await _clientService.GetClientsSp(requestDto);
            if (!clients.Success) return BadRequest(clients.Message);
            
            return Ok(clients);
        }
    }
}
