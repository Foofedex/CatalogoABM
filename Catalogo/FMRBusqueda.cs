using Acciones;
using Dominio;
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

    public partial class FMRBusqueda : Form
    {
      
        List<Articulo> articulos = new List<Articulo>();
        
        DataTable dt = new DataTable();
        
        VistaArticuloYDetalle objVistarArticulo = new VistaArticuloYDetalle();
        public FMRBusqueda()
        {
            InitializeComponent();
        }

 
        private bool ValidarEntradaTxtBusqueda(string palabraClave)
        {
            if (string.IsNullOrWhiteSpace(palabraClave))
            {
                MessageBox.Show("Por favor ingrese una letra o palabra clave.");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!ValidarEntradaTxtBusqueda(txtBusqueda.Text))
            {
                return;
            }

            //CAPTURO LA PALABRA Q INGRESO
            string busquedad = txtBusqueda.Text;
            conexionART Data= new conexionART();
            articulos = Data.Busquedad(busquedad);
           
            if(articulos.Count == 0)
            {
                MessageBox.Show("Su articulo no se encuentra.");
                LBListaBusqueda.Text = "";
                return;
            }

            foreach (Articulo articulo in articulos)
            {

                MessageBox.Show("Índice seleccionado: " + articulo.Nombre.ToString());
                LBListaBusqueda.Items.Add(articulo.Nombre );
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void LBListaBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = articulos[LBListaBusqueda.SelectedIndex ];
                objVistarArticulo.objArticulo = articuloSeleccionado;

                MessageBox.Show("Índice seleccionado: " +LBListaBusqueda.SelectedIndex.ToString());
            // Asignar el artículo seleccionado a objArticulo en objVistarArticulo
                LBListaBusqueda.Items.Clear();
                
            objVistarArticulo.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
