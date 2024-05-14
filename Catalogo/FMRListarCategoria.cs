using Acciones;
using Dominio;
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
    public partial class FMRListarCategoria : Form
    {
        private List<Categoria> ViewCategoria;
        Controller ConexionBD = new Controller();
        public FMRListarCategoria()
        {
            InitializeComponent();
        }
            
        private void FMRListarCategoria_Load(object sender, EventArgs e)
        {
            ViewCategoria = ConexionBD.ListarCategorias();
            DGVListaCategoria.DataSource = ViewCategoria;
            DGVListaCategoria.Columns[0].Visible = true;
            DGVListaCategoria.Columns[1].Visible = true;

        }
    }
}
