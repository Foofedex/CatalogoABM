using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acciones;
using Dominio;
namespace Catalogo
{
    public partial class FMRModificar : Form
    {
        string palabra;
        FMRBusqueda BusquedadModificar=new FMRBusqueda();
        Articulo ArticuloModificar=new Articulo();
        conexionART conexionART=new conexionART();
        List<Articulo>  articulos=new List<Articulo>();
        public FMRModificar()
        {
            InitializeComponent();

        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_BuscarModificar(object sender, EventArgs e)
        {
            BusquedadModificar.ShowDialog();
           ArticuloModificar =BusquedadModificar.articuloIndividual;
            MessageBox.Show(ArticuloModificar.Nombre);
            BusquedadModificar.Close();
        }

        private void TXTBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FMRModificar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda(object sender, KeyEventArgs e)
        {
            MessageBox.Show("fedex n te molestes");

        }





        private void BuscarAmodificar(object sender, EventArgs e)
        {
            MessageBox.Show(txtBuscar.Text);
            articulos = conexionART.Buscar(txtBuscar.Text);
            MessageBox.Show(articulos.Count.ToString());

            for (int i = 0; i <articulos.Count;i ++)
            {
                Articulo aux = articulos[i];
                
                cboBoxBusqueda.Items.Add(aux.Nombre);

            }
            if (articulos.Count != 0) {

            cboBoxBusqueda.Text = "Seleccione el item";
            }
        }

        private void cboSeleccionado(object sender, EventArgs e)
        {
                MessageBox.Show(cboBoxBusqueda.SelectedIndex.ToString());
            TXTBNombre.Text = articulos[cboBoxBusqueda.SelectedIndex].Nombre;
            TXTBDescripcion.Text= articulos[cboBoxBusqueda.SelectedIndex].Descripcion;
            TXTBMarca.Text = articulos[cboBoxBusqueda.SelectedIndex].Marca;
            TXTBCategoria.Text = articulos[cboBoxBusqueda.SelectedIndex].Categoria;
            TXTBPrecio.Text = articulos[cboBoxBusqueda.SelectedIndex].Precio.ToString();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Nombre = TXTBNombre.Text;
            articulo.Descripcion = TXTBDescripcion.Text;
            articulo.Marca = TXTBMarca.Text;
            articulo.Categoria = TXTBCategoria.Text;
            articulo.Precio = decimal.Parse(TXTBPrecio.Text);
            
            


        }
    }
    
}
