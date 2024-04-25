
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
                //  artiNuevo.Marca = cboMarca.Text;
                //  artiNuevo.Categoria = cboCategoria.Text;
                  artiNuevo.Precio = SqlMoney.Parse(TXTBPrecio.Text);
                  string url = txtbUrlImagen.Text;
                  artiNuevo.Imagen = validarUrl(url);
                MessageBox.Show(artiNuevo.IDCategoria.ToString()+"esta es la categoria");

                conexion.Agregar(artiNuevo);
                  MessageBox.Show("Articulo agregado");
                  Close();
              }
              
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }


            }




        private void FMRArticulo_Load_1(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            AccesoDatos accesoDatos2 = new AccesoDatos();

            try
            {

                accesoDatos.setearQuery("select id, Descripcion From Marcas");
                accesoDatos.ejecutarLectura();


                while (accesoDatos.Lector.Read())
                {
                    cboMarca.Items.Add((string)accesoDatos.Lector["Descripcion"]);

                }

                accesoDatos2.setearQuery("select id, Descripcion From CATEGORIAS");
                accesoDatos2.ejecutarLectura();

                while (accesoDatos2.Lector.Read())
                {

                    cboCategoria.Items.Add((string)accesoDatos2.Lector["Descripcion"]);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("fallo");
            }

            finally
            {
                accesoDatos.cerrarConexion();
                accesoDatos2.cerrarConexion();
            }
        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            artiNuevo.IDMarca =(cboMarca.SelectedIndex+1);
           

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            artiNuevo.IDCategoria = (cboCategoria.SelectedIndex+1);
           
        }
    }
}
