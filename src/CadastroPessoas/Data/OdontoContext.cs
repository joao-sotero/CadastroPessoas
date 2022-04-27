using Microsoft.EntityFrameworkCore;
using Odonto.Models;

namespace Odonto.Data;

public class OdontoContext : DbContext
{

    public OdontoContext(DbContextOptions<OdontoContext> opt) : base(opt)
    {
        
    }
    
    public DbSet<Pessoa> Pessoas { get; set; }

}