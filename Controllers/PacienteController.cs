using Microsoft.AspNetCore.Mvc;
using Odonto.JS.Data;
using Odonto.JS.Models;

namespace Odonto.JS.Controllers;

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
        return CreatedAtAction(nameof(GetId), new {Id = pessoa.Id}, pessoa);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Pessoas);
    }

    [HttpGet("{Id}")]
    public IActionResult GetId(long id)
    {
        Pessoa pessoa = _context.Pessoas.FirstOrDefault(x => x.Id == id);
        if(pessoa == null)
        {
            return NotFound();
        }
        return Ok(pessoa);
    }
}
