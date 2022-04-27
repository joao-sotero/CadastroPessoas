using Microsoft.AspNetCore.Mvc;
using Odonto.Data;
using Odonto.Models;

namespace Odonto.Controllers;

[ApiController]
[Route("[controller]")]
public class PacienteController : ControllerBase
{
    private readonly OdontoContext _context;

    public PacienteController(OdontoContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CadastraPaciente([FromBody] Pessoa pessoa)
    {
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetId), new { Id = pessoa.Id }, pessoa);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Pessoas);
    }

    [HttpGet("{id}")]
    public IActionResult GetId(long id)
    {
        var pessoa = _context.Pessoas.FirstOrDefault(x => x.Id == id);

        if (pessoa == null)
        {
            return NotFound();
        }

        return Ok(pessoa);
    }
}