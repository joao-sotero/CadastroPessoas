using Microsoft.EntityFrameworkCore;
using Odonto.JS.Models;

namespace Odonto.JS.Data;

public class OdontoContext : DbContext
{

    public OdontoContext(DbContextOptions<OdontoContext> opt) : base(opt)
    {
        
    }
    
    public DbSet<Pessoa> Pessoas { get; set; }

}