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

namespace Catalogo
{
    public partial class FMRListadeArticulo : Form
    {
        private List<Articulo> listarArticulo;
        public FMRListadeArticulo()
        {
            InitializeComponent();
        }

            conexionART conecArti= new conexionART();
        private void FMRListadeArticulo_Load(object sender, EventArgs e)
        {
            listarArticulo = conecArti.ListarArticulo();
            DGVArticulosLista.DataSource = listarArticulo;
            
        }

        private void DGVArticulosLista_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void DGVArticulosLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)DGVArticulosLista.CurrentRow.DataBoundItem;
            VistaArticuloYDetalle ventanaDeArt = new VistaArticuloYDetalle();
            ventanaDeArt.objArticulo = seleccionado;
            ventanaDeArt.ShowDialog();
            
        }


    }
}
