
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
using System.Diagnostics.Eventing.Reader;

namespace Catalogo
{
    public partial class FMRArticulo : Form
    {
        public Articulo artiNuevo = new Articulo();
        public FMRArticulo()
        {
            InitializeComponent();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string validarUrl(string url)
        {
            string aux=url;

            if (aux.Length < 1000) { return aux; }
            else { return aux = "Cadena muy larga"; };
          

        }



            private void BTNAdd_Click_1(object sender, EventArgs e)
            {
              
              conexionART conexion = new conexionART();
              try
              {
                  artiNuevo.Codigo = TXTBID.Text;
                  artiNuevo.Nombre = TXTBNombre.Text;
                  artiNuevo.Descripcion = TXTBDescripcion.Text;
                  artiNuevo.Marca = TXTBMarca.Text;
                  artiNuevo.Categoria = TXTBCategoria.Text;
                  artiNuevo.Precio = SqlMoney.Parse(TXTBPrecio.Text);
                  string url = txtbUrlImagen.Text;
                  artiNuevo.Imagen = validarUrl(url);
                

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
