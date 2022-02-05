using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevoo
{
    internal class Persona
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        //public int edad()
        //{
        //    DateTime hoy = DateTime.Today;
        //    int e = hoy.Year - fechaNacimiento.Year;
        //    if (hoy< fechaNacimiento.AddYears(e))
        //    {
        //        e--;
        //        return (e);
        //        //return ("la edad es " + e.ToString() + "Años";);

        //    }
        //}
    }
}
