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
    public partial class FMRListarMarca : Form
    {
        private List<Marca> ViewMarca;    
        Controller conexionBD = new Controller();
        public FMRListarMarca()
        {
            InitializeComponent();
        }

        private void FMRListarMarca_Load(object sender, EventArgs e)
        {
            ViewMarca = conexionBD.ListarMarcas();
            DGVListadoMarcas.DataSource = ViewMarca;
            DGVListadoMarcas.Columns[0].Visible = true;
            DGVListadoMarcas.Columns[1].Visible = true;
        }
    }
}
