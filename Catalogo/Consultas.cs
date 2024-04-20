using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.conexion
{
    internal class Consultas
    {
        public List<String> unDato() {
            List<String> dat = new List<String>();
            BDConexion datos=new BDConexion();
            try
            {
                datos.setearConsulta("Select Id from articulos");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    
                    string nuevo=datos.Lector["Id"].ToString();
                    unDato().Add(nuevo);

                }


            }
            catch (Exception ex) { throw ex; }
            finally { 
            
                datos.cerrarConexion();
            }
            return dat;
        }
    }
}
