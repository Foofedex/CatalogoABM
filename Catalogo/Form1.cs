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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CargaArticulo))
                {
                    MessageBox.Show("Ya se esta ejecuntando");
                    return;
                }
            }
            CargaArticulo ventana = new CargaArticulo();
            ventana.MdiParent = this;
            CargaArticulo.Show();*/
           Form CargaArticul= new Form();
            CargaArticul.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          FMRArticulo ventana= new FMRArticulo();
            ventana.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ventanaBusquedad = new Form2();
            ventanaBusquedad.ShowDialog();
       }
    }
}
