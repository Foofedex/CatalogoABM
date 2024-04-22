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
    public partial class FMRListadeArticulo : Form
    {
        public FMRListadeArticulo()
        {
            InitializeComponent();
        }

        private void FMRListadeArticulo_Load(object sender, EventArgs e)
        {
            conexionART conecArti= new conexionART();
            DGVArticulosLista.DataSource = conecArti.ListarArticulo();
        }
    }
}
