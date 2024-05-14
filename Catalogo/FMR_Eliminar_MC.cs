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

            string nombreMarca = TB_ingresar_MC_para_eliminar.Text.Trim().ToLower();

            if (RD_marca.Checked && TB_ingresar_MC_para_eliminar.Text != "")
            {
                bool marcaAEliminar = false;
                for (int i = 0; i < B_marcas.Marca().Count; i++)
                {
                    if (B_marcas.Marca()[i].DescripcionMarca.ToLower().Equals(nombreMarca))
                    {

                        marcaAEliminar = true;
                        break;
                    }

                }
                if (marcaAEliminar)
                {
                    Controller Conect = new Controller();
                    Conect.EliminarMarca(TB_ingresar_MC_para_eliminar.Text);
                    MessageBox.Show("SE ELIMINO CON EXITO");

                }
                else { MessageBox.Show("MARCA NO ENCONTRADA"); }

            }

            string nombreCategoria = TB_ingresar_MC_para_eliminar.Text.Trim().ToLower();

            if (RD_Categoria.Checked && TB_ingresar_MC_para_eliminar.Text != "")
            {
                bool CategoriaAEliminar = false;

                for (int i = 0; i < B_Categorias.Categoria().Count; i++)
                {
                    if (B_Categorias.Categoria()[i].DescripcionCategoria.ToLower().Equals(CategoriaAEliminar))
                    {

                        CategoriaAEliminar = true;
                        break;

                    }
                    if (!CategoriaAEliminar)
                    {
                        Controller Conect = new Controller();
                        Conect.EliminarCategoria(TB_ingresar_MC_para_eliminar.Text);
                        MessageBox.Show("SE ELIMINO CON EXITO");

                    }
                    else
                    {
                        MessageBox.Show("CATEGORIA NO ENCONTRADA");
                    }
                }

            }

        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
                this.Close();

        }
    }
}
