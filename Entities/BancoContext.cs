using ContaBancariaServer.Models;
using Microsoft.EntityFrameworkCore;

namespace ContaBancariaServer.Entities
{
    public class BancoContext : DbContext
    {
       public BancoContext (DbContextOptions<BancoContext> options) : base (options) { } 
       public DbSet<conta> contas { get; set; }
    }
}