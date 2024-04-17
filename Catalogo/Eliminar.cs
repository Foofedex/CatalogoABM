using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

   






        //cuando ingreso un text y le doy enter me busca la query
        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==Convert.ToChar(Keys.Enter)) listSeleccion.Items.Add(txtEliminar.Text);

        }


        //lo que seleccionamos en el list lo mostramos en el laber
        private void listSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSeleccion.SelectedIndex >= 0)
            {

                listSeleccion.Text = (string)listSeleccion.Items[listSeleccion.SelectedIndex];
                lblSeleccionado.Text = "Su seleccion de articulo fue: " + listSeleccion.Text;

            }
        }

        private void txtEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSeleccion.Items.Add(txtEliminar.Text);
            lblSeleccionado.Text = "Seleccione su Articulo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listSeleccion.Text != "") { 
            
            lblSeleccionado.Text = "";
            MessageBox.Show("Se Elimino Exitosamente: " + listSeleccion.Text);

            listSeleccion.Items.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void lblSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
