using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevoo
{
    public partial class Datos : Form
    {
        
        List<Persona> per = new List<Persona>();

        public Datos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Dpi = textBoxdpi.Text.Trim();
            persona.Nombre = textBoxnombre.Text.Trim();
            persona.Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(persona.Nombre);
            persona.Apellido = textBoxapellido.Text;
            persona.Apellido = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(persona.Apellido);
            persona.fechaNacimiento = dateTimePickeredad.Value;
            //persona.ed = eactual.Text;
            //persona.ed = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(persona.ed);
            per.Add(persona);
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            //labeldpi.Text = persona.Dpi;
            //labelnombre.Text = persona.Nombre;
            //labelapellido.Text = persona.Apellido;
            //labelfechan.Text = persona.fechaNacimiento.ToString();
            //foreach (var persona in per)
            //{
            //    writer.WriteLine(persona.Dpi);
            //    writer.WriteLine(persona.Nombre);
            //    writer.WriteLine(persona.Apellido);
            //    writer.WriteLine(persona.fechaNacimiento);
            //}
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = per;
            dataGridView1.Refresh();
        }

        private void textBoxnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CODIGO PARA BLOQUEAR TECLAS 
            //if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("solo letras", "Tome en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void textBoxapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CODIGO PARA BLOQUEAR TECLAS 
            //if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("solo letras", "Tome en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void textBoxdpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo letras y números validos", "Tome en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void buttoncalcularedad_Click(object sender, EventArgs e)
        {

        }

        private void Borrarcontenido_Click(object sender, EventArgs e)
        {
            labeldpi.Text = "";
            labelnombre.Text = "";
            labelapellido.Text = "";
            labelfechan.Text = "";
            textBoxdpi.Text = "";
            textBoxapellido.Text = "";
            textBoxnombre.Text = "";


        }
    }
}
