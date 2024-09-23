using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombres, string apellidos, DateTime fechaNacimiento, string ciudad)
        {
            Nombre = nombres;
            Apellido = apellidos;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }
    }
}
