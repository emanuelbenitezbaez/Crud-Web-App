using CrudWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApp.DataAccess
{
    public class PersonaDbContext: DbContext
    {
        public PersonaDbContext(DbContextOptions<PersonaDbContext> options) : base(options)
        {
        }

        //Agregar tablas- entidades
        public DbSet<Persona> Personas { get; set; }

    }
}
