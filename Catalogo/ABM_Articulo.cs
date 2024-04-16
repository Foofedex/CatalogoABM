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

namespace Catalogo
{
    internal class ABM_Articulo
    {
        string coneccionstring = @"Data Source=(local);Initial Catalog=CATALOGO_P3_DB;Integrated Security=True";
        DataTable DatosArticulos= new DataTable();
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

        public DataTable Buscar(string n)
        {
            string nombre = n;
            using (SqlConnection connection = new SqlConnection(coneccionstring))
            {
                try { 
                connection.Open();
                    string query = @"SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion AS Marca, c.Descripcion AS Categoria, i.ImagenUrl 
                                    FROM ARTICULOS a
                                    INNER JOIN marcas m ON a.IdMarca = m.Id
                                    INNER JOIN categorias c ON a.idcategoria = c.id
                                    INNER JOIN IMAGENES i ON a.id = i.IdArticulo
                                    WHERE a.Nombre LIKE '%nombre%' OR a.Descripcion LIKE '%nombre%' OR m.Descripcion LIKE '%nombre%' OR c.Descripcion LIKE '%nombre%';";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(DatosArticulos);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo conectar con el servidor" + ex.Message);
                }
            }


            return DatosArticulos;
        } 

       


    }



}
