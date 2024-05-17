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
            string nombreMarcaIngresada = TB_ingresar_MC.Text.Trim().ToLower();

            if (RD_marca.Checked && nombreMarcaIngresada != "")
            {
                bool marcaExistente = false;
                for (int i = 0; i < B_marcas.Marca().Count; i++)
                {
                    if (B_marcas.Marca()[i].DescripcionMarca.ToLower().Equals(nombreMarcaIngresada))
                    {
                        marcaExistente = true;
                        break;

                    }

                }
                if (!marcaExistente)

                {
                    B_marcas.AgregarMarca(nombreMarcaIngresada);
                    MessageBox.Show("SE AGREGO CON EXITO.");
                }
                else { MessageBox.Show("LA MARCA YA SE ENCUENTRA REGISTRADA."); }

            }

            string nombreCategoriaIngresada = TB_ingresar_MC.Text.Trim().ToLower();
            Controller B_Categorias = new Controller();

            if (RD_Categoria.Checked && nombreCategoriaIngresada != "")
            {
                bool categoriaExistente = false;

                for (int x = 0; x < B_Categorias.Categoria().Count; x++)
                {
                    if (B_Categorias.Categoria()[x].DescripcionCategoria.ToLower().Equals(nombreCategoriaIngresada))
                    {
                        categoriaExistente = true;
                        break;
                    }
                }

                if (!categoriaExistente)
                {
                    B_Categorias.AgregarCategoria(nombreCategoriaIngresada);
                    MessageBox.Show("SE AGREGO CON EXITO");
                }
                else
                { MessageBox.Show("LA CATEGORIA YA SE ENCUENTRA REGISTRADA."); }

            }

        }
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}