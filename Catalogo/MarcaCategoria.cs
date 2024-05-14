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
    public partial class AGREGAR_MARCA_CATEGORIA : Form
    {
        public AGREGAR_MARCA_CATEGORIA()
        {
            InitializeComponent();

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Controller B_marcas = new Controller();
            Controller B_Categorias = new Controller();

            string nombreMarca = TB_ingresar_MC.Text.Trim().ToLower();

            if (RD_marca.Checked && TB_ingresar_MC.Text != "")
            {
                bool marcaExistente = false;
                for (int i = 0; i < B_marcas.Marca().Count; i++)
                {
                    if (B_marcas.Marca()[i].DescripcionMarca.ToLower().Equals(nombreMarca))
                    {
                        marcaExistente = true;
                        break;

                    }

                }
                if (!marcaExistente)

                {
                    Controller Conect = new Controller();
                    Conect.AgregarMarca(TB_ingresar_MC.Text);
                    MessageBox.Show("SE AGREGO CON EXITO.");
                }
                else { MessageBox.Show("LA MARCA YA SE ENCUENTRA REGISTRADA."); }

            }
            
            string nombreCategoriaIngresada = TB_ingresar_MC.Text.Trim().ToLower();

            if (RD_Categoria.Checked && TB_ingresar_MC.Text != "")
            {
                bool categoriaExistente = false;

                for (int i = 0; i < B_Categorias.Categoria().Count; i++)
                {
                    if (B_Categorias.Categoria()[i].DescripcionCategoria.ToLower().Equals(nombreCategoriaIngresada))

                        categoriaExistente = true;
                    break;
                }


                if (!categoriaExistente)
                {
                    Controller Conect = new Controller();
                    Conect.AgregarCategoria(TB_ingresar_MC.Text);
                    MessageBox.Show("SE AGREGO CON EXITO");
                }
                else
                {

                    MessageBox.Show("LA CATEGORIA YA SE ENCUENTRA REGISTRADA.");

                }

            }

        }
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}