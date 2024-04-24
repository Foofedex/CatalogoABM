using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Data.SqlTypes;
using System.Reflection;
using Dominio;

namespace Acciones
{
    public class conexionART
    {

        public List<Articulo> ListarArticulo()
        {
         List<Articulo> Lista= new List<Articulo> ();
            SqlConnection conexion= new SqlConnection ();
            SqlCommand commando = new SqlCommand();
            SqlDataReader lector;
            try
                
            {   //Distintas bases de conexiones
                // conexion.ConnectionString = "server=PCFEDEX\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";
                // conexion.ConnectionString = "server=ip\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";
                // conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                commando.CommandType = System.Data.CommandType.Text;
                commando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion AS Marca, CASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END AS Categoria, i.ImagenUrl FROM ARTICULOS a LEFT JOIN marcas m ON a.IdMarca = m.Id LEFT JOIN categorias c ON a.idcategoria = c.id LEFT JOIN IMAGENES i ON a.id = i.IdArticulo;";
                commando.Connection = conexion;
                conexion.Open();
                lector= commando.ExecuteReader();

                while (lector.Read()) {

                    Articulo aux=new Articulo();

                    aux.Codigo = lector.GetString(0);
                    aux.Nombre=lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.Precio=lector.GetDecimal(3);
                    aux.Marca = lector.GetString(4);
                    aux.Categoria = lector.GetString(5);
                    aux.Imagen=lector.GetString(6);

                    /* aux.ID= (string)lector["Codigo"];
                     aux.Nombre= (string)lector["Nombre"];
                     aux.Descripcion= (string)lector["Descripcion"];
                     aux.Precio= (SqlMoney) lector["Precio"];
                     aux.Marca= (string)lector["Marca"];
                     aux.Categoria= (string)lector["Categoria"];
                     aux.Imagen = (string)lector["ImagenUrl"];*/
                    

                    
                    Lista.Add(aux);

                        
                    }



                conexion.Close();
                return Lista;   
            }

            catch(Exception ex)
            {

                throw ex;
            }
            
                finally { conexion.Close(); }   
        }



        public List<Articulo> Busquedad(string buscar)
        {
            List<Articulo> Lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand commando = new SqlCommand();
            SqlDataReader lector;
            try

            {   //Distintas bases de conexiones
                // conexion.ConnectionString = "server=PCFEDEX\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";
                // conexion.ConnectionString = "server=ip\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";
                // conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=CATALOGO_P3_DB;integrated security=true;";

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                commando.CommandType = System.Data.CommandType.Text;
                commando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion AS Marca, CASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END AS Categoria, i.ImagenUrl FROM ARTICULOS a LEFT JOIN marcas m ON a.IdMarca = m.Id LEFT JOIN categorias c ON a.idcategoria = c.id LEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%"+ buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';";
                commando.Connection = conexion;
                conexion.Open();
                lector = commando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.Codigo = lector.GetString(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.Precio = lector.GetDecimal(3);
                    aux.Marca = lector.GetString(4);
                    aux.Categoria = lector.GetString(5);
                    aux.Imagen = lector.GetString(6);

                    /* aux.ID= (string)lector["Codigo"];
                     aux.Nombre= (string)lector["Nombre"];
                     aux.Descripcion= (string)lector["Descripcion"];
                     aux.Precio= (SqlMoney) lector["Precio"];
                     aux.Marca= (string)lector["Marca"];
                     aux.Categoria= (string)lector["Categoria"];
                     aux.Imagen = (string)lector["ImagenUrl"];*/



                    Lista.Add(aux);


                }



                conexion.Close();
                return Lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }

            finally { conexion.Close(); }
        }

        public void Agregar(Articulo artNuevo)
        {

            artNuevo.Categoria = "1";
            artNuevo.Marca = "1";
            artNuevo.Nombre= "1";
            artNuevo.Descripcion= "1";
            artNuevo.Codigo = "1";
            artNuevo.Precio = (decimal)50.5;
            //conexion a bd
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES('x', 'l', 'prueba2', 1, 2, 5)");
                datos.ejecutarAccion();



                //datos.setearQuery("INSERT INTO IMAGENES(ImagenUrl, idArticulo) VALUES('" + artNuevo.Imagen + "', (SELECT MAX(id) FROM Articulos))");
              //
              //datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }




    }
}
