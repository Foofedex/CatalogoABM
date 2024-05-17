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
            bool b = false;

            int cantidadMarca = B_marcas.ContadorMarca(TB_ingresar_MC_para_eliminar.Text);

            if (RD_marca.Checked && TB_ingresar_MC_para_eliminar.Text == "")
            {
                MessageBox.Show("Ingrese la marca a eliminar");
            }

            if (cantidadMarca > 0 && RD_marca.Checked)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    b = true;
                }

            }

            if (b == true || (cantidadMarca == 0 && RD_marca.Checked))
            {

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

                }
                else { MessageBox.Show("MARCA NO ENCONTRADA"); }
            }


            string nombreCategoria = TB_ingresar_MC_para_eliminar.Text.Trim().ToLower();
            bool cate = false;

            int cantidadCategoria = B_Categorias.ContadorCategoria(TB_ingresar_MC_para_eliminar.Text);

            if (RD_Categoria.Checked && TB_ingresar_MC_para_eliminar.Text == "")
            {
                MessageBox.Show("Ingrese la Categoria a eliminar");
            }

            if (cantidadCategoria > 0 && RD_Categoria.Checked)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la Categoria?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                if (CategoriaAEliminar)
                {
                    Controller Conect = new Controller();
                    Conect.EliminarCategoria(TB_ingresar_MC_para_eliminar.Text);
                    MessageBox.Show("SE ELIMINO CON EXITO");

                }

            }
            else { MessageBox.Show("CATEGORIA NO ENCONTRADA"); }
        }



        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
