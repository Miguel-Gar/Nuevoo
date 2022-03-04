using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string ed { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad()
        {
            DateTime hoy = DateTime.Today;
            int e = hoy.Year - fechaNacimiento.Year;
            if (hoy < fechaNacimiento.AddYears(e))
            {
                e--;
            }
            return (e);
        }
        public void normalizaNombre()
        {
            Nombre = Nombre.Trim();           
            Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Nombre);
            Apellido = Apellido.Trim();
            Apellido = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Apellido);
        }
    }
}
