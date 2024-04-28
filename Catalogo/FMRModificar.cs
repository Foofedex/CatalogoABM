using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acciones;
using Dominio;
namespace Catalogo
{
    public partial class FMRModificar : Form
    {
        
        FMRBusqueda BusquedadModificar=new FMRBusqueda();
        Articulo ArticuloModificar=new Articulo();
        Controller conexionART=new Controller();
        List<Articulo>  articulos=new List<Articulo>();
        List<Articulo> Marca=new List<Articulo>();
        List<Articulo> Categoria= new List<Articulo>();

        int seleccionLista=-1;
        public FMRModificar()
        {
            InitializeComponent();

        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

  
        private void BuscarAmodificar(object sender, EventArgs e)
        {
            
            cboBoxBusqueda.Items.Clear();
            CboCategoria.Items.Clear();
            CboMarca.Items.Clear(); 
            
            
            List<Articulo> articulosBuscados = new List<Articulo>();

            articulosBuscados= conexionART.Buscar(txtBuscar.Text);

            for (int i = 0; i < articulosBuscados.Count;i ++)
            {
                Articulo aux = articulosBuscados[i];
                if (aux.Nombre != null) { 
                cboBoxBusqueda.Items.Add(aux.Nombre);
                }
            }
            if (articulosBuscados.Count != 0) {

            cboBoxBusqueda.Text = "Seleccione el item";
            }
            articulos = articulosBuscados;
         
        }
        //articulo encontrado
        private void cboSeleccionado(object sender, EventArgs e)
        {

            seleccionLista = cboBoxBusqueda.SelectedIndex;
            TXTCodigo.Text = articulos[cboBoxBusqueda.SelectedIndex].Codigo;
            TXTBDescripcion.Text= articulos[cboBoxBusqueda.SelectedIndex].Descripcion;
            CboMarca.Text=articulos[cboBoxBusqueda.SelectedIndex].Marca;
            CboCategoria.Text=articulos[cboBoxBusqueda.SelectedIndex].Categoria;
            TxtPrecio.Text = articulos[cboBoxBusqueda.SelectedIndex].Precio.ToString();
            TxtURL.Text= articulos[cboBoxBusqueda.SelectedIndex].Imagen.ToString();
            ArticuloModificar.IDCategoria = articulos[cboBoxBusqueda.SelectedIndex].IDCategoria;
            ArticuloModificar.id = articulos[cboBoxBusqueda.SelectedIndex].id;
            ArticuloModificar.IDMarca = articulos[cboBoxBusqueda.SelectedIndex].IDMarca;

           
            Marca = conexionART.Marca();
            for (int i = 0; i < Marca.Count; i++)
            {
               
                CboMarca.Items.Add(Marca[i].Marca.ToString());
               
            }
            Categoria = conexionART.Categoria();

            for (int i = 0; i < Categoria.Count; i++)
            {
                
                CboCategoria.Items.Add(Categoria[i].Descripcion.ToString());
                
            }
                        
        }


        private void SeleccionMarca(object sender, EventArgs e)
        {
            ArticuloModificar.IDMarca =Marca[CboMarca.SelectedIndex].IDMarca;
           
        }

        private void SeleccionCategoria(object sender, EventArgs e)
        {
         
            ArticuloModificar.IDCategoria = Categoria[CboCategoria.SelectedIndex].IDCategoria;
        }


        private void BTNModificar_Click(object sender, EventArgs e)
        {
            
                        ArticuloModificar.Nombre = cboBoxBusqueda.Text;
                        ArticuloModificar.Codigo=TXTCodigo.Text;
                        ArticuloModificar.Descripcion = TXTBDescripcion.Text;
                        ArticuloModificar.Precio= SqlMoney.Parse( TxtPrecio.Text);
                        ArticuloModificar.Imagen = TxtURL.Text;

           
           

            MessageBox.Show("SE MODIFICO CON EXITO");
     
            

            Controller conexionART = new Controller();
            conexionART.Modificar(ArticuloModificar);
            
        }

    }
    
}
