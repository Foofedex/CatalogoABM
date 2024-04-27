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
        string palabra;
        FMRBusqueda BusquedadModificar=new FMRBusqueda();
        Articulo ArticuloModificar=new Articulo();
        conexionART conexionART=new conexionART();
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

            MessageBox.Show(articulos[cboBoxBusqueda.SelectedIndex].id.ToString());
            ArticuloModificar.IDCategoria = articulos[cboBoxBusqueda.SelectedIndex].IDCategoria;
            ArticuloModificar.id = articulos[cboBoxBusqueda.SelectedIndex].id;
            ArticuloModificar.IDMarca = articulos[cboBoxBusqueda.SelectedIndex].IDMarca;

            //asignamos a nuevo objeto a modificar los valores que seleccion en el combobox
            // ArticuloModificar.Nombre = articulos[cboBoxBusqueda.SelectedIndex].Marca;
            // ArticuloModificar.Nombre = articulos[cboBoxBusqueda.SelectedIndex].Categoria;
            //aqui hacemos la consulda de las marcas y categoria


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
            MessageBox.Show(" categoria: " + ArticuloModificar.IDCategoria.ToString() + " marca: " + ArticuloModificar.IDMarca.ToString());
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

           
            /*
            ArticuloModificar.id = 2; 
            ArticuloModificar.Codigo = "CEL";
            ArticuloModificar.Nombre = "Fedexc";
            ArticuloModificar.Descripcion = "Lunes a Viernes";
            ArticuloModificar.Precio = 10000;
            ArticuloModificar.Imagen = "www.google.com";
            ArticuloModificar.IDMarca = 2;
            ArticuloModificar.IDCategoria = 2;
            */
            /*
             update ARTICULOS set 
            Codigo='"+Modificar.Codigo + "', 
            Nombre='" +Modificar.Nombre + "', 
            Descripcion='"+ 
            Modificar.Descripcion + "',IdMarca='"+ 
            Modificar.IDMarca + "', IdCategoria='"+ 
            Modificar.IDCategoria + "', precio='" + 
            Modificar.Precio + "' where id= '" + 
            Modificar.id + "' 
            update IMAGENES set ImagenUrl='" + 
            Modificar.Imagen + "' where '" + 
            Modificar.id + "'=IMAGENES.IdArticulo
             */

            MessageBox.Show("a enviar: "+" id "+ ArticuloModificar.id + " "+ ArticuloModificar.Nombre+ 
                " " +ArticuloModificar.Codigo+" "+ ArticuloModificar.Descripcion+
                " " + ArticuloModificar.Precio.ToString()+
                " " + ArticuloModificar.Imagen);
     
            

            conexionART conexionART = new conexionART();
            conexionART.Modificar(ArticuloModificar);
            
        }

    }
    
}
