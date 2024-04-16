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
    public partial class FMRBusqueda : Form
    {
        ABM_Articulo articulo= new ABM_Articulo();
        DataTable dt = new DataTable();
        public FMRBusqueda()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            
            string busquedad = txtBusqueda.Text;
            
            dt= articulo.Buscar(busquedad);
            LBListaBusqueda.Items.Add(dt);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
