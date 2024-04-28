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
    public class Controller
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
                commando.CommandText = "SELECT a.id,a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca,  c.Id AS IDCategoria,  c.Descripcion ,i.ImagenUrl FROM ARTICULOS a inner JOIN marcas m ON a.IdMarca = m.Id inner JOIN categorias c ON a.idcategoria = c.id inner JOIN IMAGENES i ON a.id = i.IdArticulo;";
                commando.Connection = conexion;
                conexion.Open();
                lector= commando.ExecuteReader();

                while (lector.Read()) {

                    Articulo aux=new Articulo();
                    aux.id= lector.GetInt32(0);
                    aux.Codigo = lector.GetString(1);
                    aux.Nombre=lector.GetString(2);
                    aux.Descripcion = lector.GetString(3);
                    aux.Precio=lector.GetSqlMoney(4);
                    aux.IDMarca=lector.GetInt32 (5);
                    aux.Marca = lector.GetString(6);
                    aux.IDCategoria = lector.GetInt32(7);
                    aux.Categoria = lector.GetString(8);
                    aux.Imagen=lector.GetString(9);
                                                          
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

        //buscar un articulo
        public List<Articulo> Buscar(string buscar)
        {
            AccesoDatos nuevaConexion = new AccesoDatos();
            List<Articulo> articuloList = new List<Articulo>();

            nuevaConexion.setearQuery("SELECT a.id ,a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, \r\nCASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl \r\nFROM ARTICULOS a\r\nLEFT JOIN marcas m ON a.IdMarca = m.Id\r\nLEFT JOIN categorias c ON a.idcategoria = c.id \r\nLEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%" + buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';");
            nuevaConexion.ejecutarLectura();
            while (nuevaConexion.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.id= nuevaConexion.Lector.GetInt32(0);
                aux.Codigo = nuevaConexion.Lector.GetString(1);
                aux.Nombre = nuevaConexion.Lector.GetString(2);
                aux.Descripcion = nuevaConexion.Lector.GetString(3);
                aux.Precio = nuevaConexion.Lector.GetSqlMoney(4);
                aux.IDMarca = nuevaConexion.Lector.GetInt32(5);
                aux.Marca = nuevaConexion.Lector.GetString(6);
                aux.IDCategoria = nuevaConexion.Lector.GetInt32(7);
                aux.Categoria = nuevaConexion.Lector.GetString(8);
                aux.Imagen = nuevaConexion.Lector.GetString(9);

                articuloList.Add(aux);

            }
            nuevaConexion.cerrarConexion();
            
            return articuloList;
        }
        //consulta de marca
        public List<Articulo> Marca() {
            AccesoDatos nuevaConexion = new AccesoDatos();
            List<Articulo> articuloList = new List<Articulo>();

            nuevaConexion.setearQuery("SELECT * from Marcas"); 
            nuevaConexion.ejecutarLectura();
            while (nuevaConexion.Lector.Read())
            {
                Articulo aux= new Articulo();
                aux.IDMarca = nuevaConexion.Lector.GetInt32(0);
                aux.Marca = nuevaConexion.Lector.GetString(1);
                articuloList.Add(aux);
            }
            nuevaConexion.cerrarConexion();
            return articuloList;
        }

        //consulta de categoria 
        public List<Articulo> Categoria()
        {
            AccesoDatos nuevaConexion = new AccesoDatos();
            List<Articulo> articuloList = new List<Articulo>();
            nuevaConexion.setearQuery("SELECT * from Categorias");
            nuevaConexion.ejecutarLectura();
            while (nuevaConexion.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.IDCategoria = nuevaConexion.Lector.GetInt32(0);
                aux.Descripcion = nuevaConexion.Lector.GetString(1);
                articuloList.Add(aux);
            }




            nuevaConexion.cerrarConexion();
            return articuloList;
        }

        //modificar
        public void Modificar(Articulo Modificar)
        {

            AccesoDatos nuevaConexion = new AccesoDatos();
            
            nuevaConexion.setearQuery("update ARTICULOS set Codigo='"+ Modificar.Codigo + "', Nombre='" + Modificar.Nombre + "', Descripcion='"+ Modificar.Descripcion + "',IdMarca='"+ Modificar.IDMarca + "', IdCategoria='"+ Modificar.IDCategoria + "', precio='" + Modificar.Precio + "' where id= '" + Modificar.id + "' update IMAGENES set ImagenUrl='" + Modificar.Imagen + "' where '" + Modificar.id + "'=IMAGENES.IdArticulo");
            nuevaConexion.ejecutarLectura();
            nuevaConexion.cerrarConexion();
            
            return;
        }


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
                commando.CommandText = "SELECT a.id, a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.id as IDMarca, m.Descripcion AS Marca, CASE WHEN c.Id IS NULL THEN '0' ELSE c.Id END AS IDCategoria, \r\nCASE WHEN c.Descripcion IS NULL THEN '0' ELSE c.Descripcion END ,i.ImagenUrl FROM ARTICULOS a LEFT JOIN marcas m ON a.IdMarca = m.Id LEFT JOIN categorias c ON a.idcategoria = c.id  LEFT JOIN IMAGENES i ON a.id = i.IdArticulo where a.Nombre like '%"+ buscar + "%' or a.Descripcion like '%" + buscar + "%' or m.Descripcion like '%" + buscar + "%' or c.Descripcion like '%" + buscar + "%';";
                commando.Connection = conexion;
                conexion.Open();
                lector = commando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.id = lector.GetInt32(0);
                    aux.Codigo = lector.GetString(1);
                    aux.Nombre = lector.GetString(2);
                    aux.Descripcion = lector.GetString(3);
                    aux.Precio = lector.GetSqlMoney(4);
                    aux.IDMarca = lector.GetInt32(5);
                    aux.Marca = lector.GetString(6);
                    aux.IDCategoria = lector.GetInt32(7);
                    aux.Categoria = lector.GetString(8);
                    aux.Imagen = lector.GetString(9);

                    

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

        public void AgregarMarca(string a) 
        {
            AccesoDatos conect= new AccesoDatos();
            string b = a.Substring(0, 1).ToUpper() + a.Substring(1).ToLower();
            conect.setearQuery("insert into MARCAS(descripcion) values('"+b+"');");
            conect.ejecutarAccion();
            conect.cerrarConexion();
        }

        public void AgregarCategoria(string a)
        {
            AccesoDatos conect = new AccesoDatos();

            string b = a.Substring(0, 1).ToUpper() + a.Substring(1).ToLower();
            conect.setearQuery("insert into CATEGORIAS(descripcion) values('" +b+ "');");
            conect.ejecutarAccion();
            conect.cerrarConexion();
        }

        public void EliminarCategoria(string a)
        {
            AccesoDatos conect = new AccesoDatos();
            conect.setearQuery("delete from CATEGORIAS  where Descripcion='"+a+"'");
            conect.ejecutarAccion();
            conect.cerrarConexion();
        }
        public void EliminarMarca(string a)
        {
            AccesoDatos conect = new AccesoDatos();
            conect.setearQuery("delete from MARCAS  where Descripcion='"+a+"'");
            conect.ejecutarAccion();
            conect.cerrarConexion();
        }

    }
}
