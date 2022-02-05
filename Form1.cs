using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevoo
{
    public partial class Datos : Form
    {
        Persona persona = new Persona();
        public Datos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Dpi = textBoxdpi.Text.Trim();
            persona.Nombre = textBoxnombre.Text;
            persona.Apellido = textBoxapellido.Text;
            persona.fechaNacimiento = dateTimePickeredad.Value;
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            int q = 0;
            string extra = "";
            for (int x = 0; x < persona.Nombre.Length; x++)
            {
                extra=persona.Nombre.Substring(x, 1);
                switch (extra)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    default:extra = extra+1; 
                        break;
                }
            }
            labeldpi.Text = persona.Dpi;
            labelnombre.Text = persona.Nombre;
            labelapellido.Text = persona.Apellido;
            labelfechan.Text = persona.fechaNacimiento.ToString();
        }

        private void textBoxnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("solo letras", "Tome en cuenta", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void textBoxapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("solo letras", "Tome en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void textBoxdpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("solo letras y números validos", "Tome en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void buttoncalcularedad_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            int ed = hoy.Year - persona.fechaNacimiento.Year;
            if (hoy < persona.fechaNacimiento.AddYears(ed))
            {
                ed--;
                eactual.Text = "la edad es " + ed.ToString() + " Años";
            }
        }
    }
}
