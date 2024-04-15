using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class Articulo
    {
        public int ID;
        public string Nombre;
        public string Descripcion;
        public string Marca;
        public string Categoria;
        public SqlMoney Precio;
        public string Imagen;

        public void Cargar()
        {

        }
    }   
}
