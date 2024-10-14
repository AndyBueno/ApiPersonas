using ApiPersonas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPersonas.Context;

public class AppDbContext : DbContext
{
    /*Creamos el constructor para inicializar el dbcontext*/
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }
    public DbSet<Person> Personas { get; set; }
}