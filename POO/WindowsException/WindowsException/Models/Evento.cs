using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsException.Models
{
    public class Evento
    {

        public Evento(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha de finalización");
            }

            if (fechaFin<fechaInicio)
            {
                throw new Exception("La fecha de finalización no puede ser anterior a la fecha de inicio");
            }

            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;   
        }

        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacio o superar los 50 caracteres");
                
                }
                nombre = value; 
            
            }
        }

    }
}
