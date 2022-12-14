using Microsoft.EntityFrameworkCore;
using RegistroOcupacion.Entidades;

namespace RegistroOcupacion.DAL{
public class Contexto : DbContext
{
    public DbSet<Ocupaciones> Ocupaciones { get; set; }

    public DbSet<Persona> Persona { get; set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

}
}
 