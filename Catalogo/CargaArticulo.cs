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
    public partial class FMRArticulo : Form
    {
        public FMRArticulo()
        {
            InitializeComponent();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
