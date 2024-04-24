
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Acciones;
using System.Data.SqlTypes;

namespace Catalogo
{
    public partial class FMRArticulo : Form
    {
        public FMRArticulo()
        {
            InitializeComponent();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMRArticulo_Load(object sender, EventArgs e)
        {

        }

        private void TXTBID_TextChanged(object sender, EventArgs e)
        {
     
        }
        /*
         
         
         
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Articulo artiNuevo = new Articulo();
            conexionART conexion = new conexionART();
            try
            {
                artiNuevo.Codigo = TXTBID.Text;
                artiNuevo.Nombre = TXTBNombre.Text;
                artiNuevo.Descripcion = TXTBDescripcion.Text;
                artiNuevo.Marca = TXTBMarca.Text;
                artiNuevo.Categoria = TXTBCategoria.Text;
                artiNuevo.Precio = decimal.Parse(TXTBPrecio.Text);
                artiNuevo.Imagen = txtbUrlImagen.Text;

                conexion.Agregar(artiNuevo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
         */
        
        private void BTNAdd_Click_1(object sender, EventArgs e)
        {
            Articulo artiNuevo = new Articulo();
            conexionART conexion = new conexionART();
            try
            {
                artiNuevo.Codigo = TXTBID.Text;
                artiNuevo.Nombre = TXTBNombre.Text;
                artiNuevo.Descripcion = TXTBDescripcion.Text;
                artiNuevo.Marca = TXTBMarca.Text;
                artiNuevo.Categoria = TXTBCategoria.Text;
                artiNuevo.Precio = decimal.Parse(TXTBPrecio.Text);



                if (decimal.Parse(TXTBPrecio.Text) >= 0) {
                    artiNuevo.Precio= decimal.Parse(TXTBPrecio.Text);
                }else
                {
                    TXTBPrecio.Text = "0";
                    artiNuevo.Precio = decimal.Parse(TXTBPrecio.Text);
                }

               
                MessageBox.Show(TXTBPrecio.Text);
                // artiNuevo.Imagen = txtbUrlImagen.Text;

                conexion.Agregar(artiNuevo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
         
    }
}
