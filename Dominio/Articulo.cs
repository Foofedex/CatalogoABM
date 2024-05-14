using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string DescripcionCateoria { get; set; }
        public string Marca { get; set; }

        public Marca marca = new Marca();

        public Categoria categoria = new Categoria();
        public SqlMoney Precio { get; set; }
        public string Imagen { get; set; }
    }
        public class Categoria
        {
            public Categoria() { }
            public int IDCategoria { get; set; }
            public string DescripcionCategoria { get; set; }
        }
        public class Marca
        {
            public Marca() { }
            public int IDMarca { get; set; }
            public string DescripcionMarca { get; set; }

        }
      
}
