using ApiClientes.Data;
using ApiClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientesController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpPost]
    public async Task<IActionResult> RegisterCustomer([FromBody] Cliente cliente)
    {

        var emailExiste = await _context.Clientes
            .AnyAsync(c => c.Email == cliente.Email);

        if (emailExiste)
            return BadRequest("Já existe um cliente cadastrado com esse email.");

        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetAll),
            new { id = cliente.Id },
            cliente
        );
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var clientes = await _context.Clientes.ToListAsync();
        return Ok(clientes);
    }

}
