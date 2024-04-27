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
        
        List<Articulo> articuloList=new List<Articulo>();
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
                commando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, \r\nCASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl \r\nFROM ARTICULOS a\r\nLEFT JOIN marcas m ON a.IdMarca = m.Id\r\nLEFT JOIN categorias c ON a.idcategoria = c.id \r\nLEFT JOIN IMAGENES i ON a.id = i.IdArticulo;";
                commando.Connection = conexion;
                conexion.Open();
                lector= commando.ExecuteReader();

                while (lector.Read()) {

                    Articulo aux=new Articulo();

                    aux.Codigo = lector.GetString(0);
                    aux.Nombre=lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.Precio=lector.GetSqlMoney(3);
                    aux.IDMarca=lector.GetInt32 (4);
                    aux.Marca = lector.GetString(5);
                    aux.IDCategoria = lector.GetInt32(6);
                    aux.Categoria = lector.GetString(7);
                    aux.Imagen=lector.GetString(8);
                                                          
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



        public List<Articulo> Buscar(string buscar) {
            AccesoDatos nuevaConexion = new AccesoDatos();
            
            nuevaConexion.setearQuery("SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, \r\nCASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl \r\nFROM ARTICULOS a\r\nLEFT JOIN marcas m ON a.IdMarca = m.Id\r\nLEFT JOIN categorias c ON a.idcategoria = c.id \r\nLEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%" + buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';"); 
            nuevaConexion.ejecutarLectura();
            while (nuevaConexion.Lector.Read())
            {
                Articulo aux= new Articulo();
                
                aux.Codigo = nuevaConexion.Lector.GetString(0);
                aux.Nombre = nuevaConexion.Lector.GetString(1);
                aux.Descripcion = nuevaConexion.Lector.GetString(2);
                aux.Precio = nuevaConexion.Lector.GetSqlMoney(3);
                aux.IDMarca = nuevaConexion.Lector.GetInt32(4);
                aux.Marca = nuevaConexion.Lector.GetString(5);
                aux.IDCategoria = nuevaConexion.Lector.GetInt32(6);
                aux.Categoria = nuevaConexion.Lector.GetString(7);
                aux.Imagen = nuevaConexion.Lector.GetString(8);

                articuloList.Add(aux);

            }




            nuevaConexion.cerrarConexion();
            return articuloList;
        }

        /*   se tiene que modificar para poder mandar a la base de datos
        public List<Articulo> Modificar(Articulo buscar)
        {
            AccesoDatos nuevaConexion = new AccesoDatos();

            nuevaConexion.setearQuery("SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, \r\nCASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl \r\nFROM ARTICULOS a\r\nLEFT JOIN marcas m ON a.IdMarca = m.Id\r\nLEFT JOIN categorias c ON a.idcategoria = c.id \r\nLEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%" + buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';");
            nuevaConexion.ejecutarLectura();
            while (nuevaConexion.Lector.Read())
            {
                Articulo aux = new Articulo();

                aux.Codigo = nuevaConexion.Lector.GetString(0);
                aux.Nombre = nuevaConexion.Lector.GetString(1);
                aux.Descripcion = nuevaConexion.Lector.GetString(2);
                aux.Precio = nuevaConexion.Lector.GetSqlMoney(3);
                aux.IDMarca = nuevaConexion.Lector.GetInt32(4);
                aux.Marca = nuevaConexion.Lector.GetString(5);
                aux.IDCategoria = nuevaConexion.Lector.GetInt32(6);
                aux.Categoria = nuevaConexion.Lector.GetString(7);
                aux.Imagen = nuevaConexion.Lector.GetString(8);

                articuloList.Add(aux);

            }




            nuevaConexion.cerrarConexion();
            return articuloList;
        }

*/














        public List<Articulo> Busquedad(string buscar)
        {
            List<Articulo> Lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand commando = new SqlCommand();
            SqlDataReader lector;
            try

            {   

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                commando.CommandType = System.Data.CommandType.Text;
                commando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, \r\nCASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl \r\nFROM ARTICULOS a\r\nLEFT JOIN marcas m ON a.IdMarca = m.Id\r\nLEFT JOIN categorias c ON a.idcategoria = c.id \r\nLEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%"+ buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';";
                commando.Connection = conexion;
                conexion.Open();
                lector = commando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.Codigo = lector.GetString(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.Precio = lector.GetSqlMoney(3);
                    aux.IDMarca = lector.GetInt32(4);
                    aux.Marca = lector.GetString(5);
                    aux.IDCategoria = lector.GetInt32(6);
                    aux.Categoria = lector.GetString(7);
                    aux.Imagen = lector.GetString(8);

                    

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

          
            //conexion a bd
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
              
                datos.setearQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('"+artNuevo.Codigo+"','" + artNuevo.Nombre+"', '" + artNuevo.Descripcion + "','" + artNuevo.IDMarca + "','" + artNuevo.IDCategoria+ "','" + artNuevo.Precio + "') INSERT INTO IMAGENES(idArticulo, ImagenUrl) VALUES((SELECT MAX(id) FROM Articulos),'" + artNuevo.Imagen + "');");


                datos.ejecutarAccion();

           
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
