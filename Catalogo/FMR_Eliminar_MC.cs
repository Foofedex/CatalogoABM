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
    public partial class FMR_Eliminar_MC : Form
    {
        public FMR_Eliminar_MC()
        {
            InitializeComponent();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            Controller B_marcas = new Controller();
            Controller B_Categorias = new Controller();
            bool b = false;

            int cantidadArticulos = B_marcas.ContadorArtxmarca(TB_ingresar_MC_para_eliminar.Text.Trim().ToLower());

            if (RD_marca.Checked && TB_ingresar_MC_para_eliminar.Text == "")
            {
                MessageBox.Show("Ingrese la marca a eliminar");
            }
            
            if (cantidadArticulos > 0 && RD_marca.Checked)
            {
                DialogResult result = MessageBox.Show("¿la marca tiene "+ cantidadArticulos+ " articulos asociados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    b = true;
                }

            }
            

            if (b == true || (cantidadArticulos == 0 && RD_marca.Checked))
            {

                string nombreMarca = TB_ingresar_MC_para_eliminar.Text.Trim().ToLower();

                bool marcaAEliminar = false;
                    Marca eliminar = new Marca();
                if (RD_marca.Checked && nombreMarca != "")
                {
                    for (int i = 0; i < B_marcas.Marca().Count; i++)
                    {
                        if (B_marcas.Marca()[i].DescripcionMarca.ToLower().Equals(nombreMarca))
                        {

                            marcaAEliminar = true;
                            break;
                        }
                       

                    }

                }
                if (!marcaAEliminar)
                {
                    MessageBox.Show("MARCA NO ENCONTRADA");
                }
               
                    if (marcaAEliminar)
                    {
                        Controller Conect = new Controller();
                        Conect.EliminarMarca(nombreMarca);
                        MessageBox.Show("SE ELIMINO CON EXITO");

                    }

                
               
            }
           


            string nombreCategoria = TB_ingresar_MC_para_eliminar.Text.Trim().ToLower();
            bool cate = false;

            int cantidadCategoria = B_Categorias.ContadorArtxCategoria(TB_ingresar_MC_para_eliminar.Text);

            if (RD_Categoria.Checked && TB_ingresar_MC_para_eliminar.Text == "")
            {
                MessageBox.Show("Ingrese la Categoria a eliminar");
            }

            if (cantidadCategoria > 0 && RD_Categoria.Checked)
            {
                DialogResult result = MessageBox.Show("¿la Categoria tiene "+ cantidadCategoria+" articulos asosiados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cate = true;
                }

            }

            if (cate == true || (cantidadCategoria == 0 && RD_Categoria.Checked))
            {
                bool CategoriaAEliminar = false;
                for (int i = 0; i < B_Categorias.Categoria().Count; i++)
                {
                    if (B_Categorias.Categoria()[i].DescripcionCategoria.ToLower().Equals(nombreCategoria))
                    {

                        CategoriaAEliminar = true;
                        break;

                    }
                }
                if (!CategoriaAEliminar) { MessageBox.Show("Categoria no encontrada"); }

                if (CategoriaAEliminar)
                {
                    Controller Conect = new Controller();
                    Conect.EliminarCategoria(TB_ingresar_MC_para_eliminar.Text);
                    MessageBox.Show("SE ELIMINO CON EXITO");

                }

            }
          
        }



        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
