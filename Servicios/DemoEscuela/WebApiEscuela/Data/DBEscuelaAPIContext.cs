
using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;
namespace WebApiEscuela.Data
{
    public class DBEscuelaAPIContext:DbContext
    {
        //CORE siempre vamos a declarar el contructor de está forma
        public DBEscuelaAPIContext(DbContextOptions<DBEscuelaAPIContext> options ):base(options) { }

        //DBSET
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
            
    }
}
