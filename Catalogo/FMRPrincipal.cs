using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

       
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
          
           Form CargaArticul= new Form();
            CargaArticul.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          FMRArticulo ventana= new FMRArticulo();
            ventana.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRBusqueda ventanaBusquedad = new FMRBusqueda();
            ventanaBusquedad.ShowDialog();
       }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Catalago v1.0 creado por Daniel Guillen, Ale y Fede");       }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRModificar modificarART= new FMRModificar();
            modificarART.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRListadeArticulo listadeArticulo= new FMRListadeArticulo();
            listadeArticulo.ShowDialog();
        }
    }
}
