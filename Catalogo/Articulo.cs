﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    public class Articulo
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public SqlMoney Precio { get; set; }
        public string Imagen { get; set; }

        public void Cargar()
        {

        }
    }   
}
