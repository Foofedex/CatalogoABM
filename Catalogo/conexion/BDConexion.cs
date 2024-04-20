using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.conexion
{
    internal class BDConexion
    {
        SqlConnection nuevaConexion;
        SqlCommand comandos;
        SqlDataReader Lectura;
        SqlDataAdapter DataAdapter;
        private SqlDataReader lector;

        public BDConexion() {
            nuevaConexion = new SqlConnection("server=DaniPC\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security=true");
            comandos = new SqlCommand(); 
        
        }
        public SqlDataReader Lector { 
            get { return lector; }  
        }
        public void ejecutarLectura() {
            comandos.Connection = nuevaConexion;
            try {
                conexion.open();
                lector = comandos.ExecuteReader();
            
            }catch (Exception ex)
            {
                throw ex;

            }
        }

        public void cerrarConexion()
        {

            if (lector != null)
            {
                lector.Close();
                conexion.Close();
            }
        }


        public void setearConsulta(string consulta) {
        comandos.CommandType=System.Data.CommandType.Text;
        comandos.CommandText=consulta;
        }




    }
}
