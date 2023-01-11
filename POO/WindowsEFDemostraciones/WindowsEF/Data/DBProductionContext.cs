using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsEF.Models;
using System.Data.Entity;
namespace WindowsEF.Data
{
    public class DBProductionContext:DbContext
    {
        public DBProductionContext() : base("keyDBProduction") { }

        // por cada modelo una propiedad DBSET
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder); 

            //Configuración mapeo con FLUENT API

            //PK
            modelBuilder.Entity<Empleado>().HasKey(e => e.SID);

            //Campo obligatorio
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).IsRequired();

            //Tipo de dato
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnType("varchar");

            //Longitud de la cadena
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasMaxLength(50);

            //Nombre tabla
            modelBuilder.Entity<Empleado>().ToTable("Empleado");


            //Relación de uno a uno
            modelBuilder.Entity<Employee>().HasOptional(e => e.EmployeeDetail).WithRequired(e => e.Employee);

        }



    }
}
