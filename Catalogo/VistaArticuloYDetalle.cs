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
    public partial class VistaArticuloYDetalle : Form
    {
        public Articulo objArticulo;
        public VistaArticuloYDetalle()
        {
            InitializeComponent();
        }
   

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaArticuloYDetalle_Load(object sender, EventArgs e)
        {
            
            lblCodigo2.Text= objArticulo.ID.ToString();
            lblNombre2.Text= objArticulo.Nombre.ToString();
            lblDescripcion2.Text=objArticulo.Descripcion.ToString();
            lblCategoria2.Text=objArticulo.Categoria.ToString();
            lblMarca2.Text=objArticulo.Marca.ToString();
            CargarImagen(objArticulo.Imagen.ToString());
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                PicBoxImg.Load(imagen);
            }
            catch(Exception ex)
            {
                PicBoxImg.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
    }
}
