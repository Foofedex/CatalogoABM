using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Catalogo
{
    internal class ABM_Articulo
    {
        
       
        public List<Articulo> list = new List<Articulo>();
       

        //metodos
       public void Alta(Articulo a)
        {

        list.Add(a);

        }
        
        public void Baja(int ID)
        {
        }

        public void Modificar(int ID) 
        {
        }
        public void Listar(List<Articulo> list)
        {
            list = new List<Articulo>();


        }

        public Articulo Buscar(string n)
        {
            Articulo aux = new Articulo();
            /*
         
                    "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion AS Marca, c.Descripcion AS Categoria, i.ImagenUrl 
                                    FROM ARTICULOS a
                                    INNER JOIN marcas m ON a.IdMarca = m.Id
                                    INNER JOIN categorias c ON a.idcategoria = c.id
                                    INNER JOIN IMAGENES i ON a.id = i.IdArticulo;

                   
              
            }
            */

            return aux;
        } 

       


    }



}
