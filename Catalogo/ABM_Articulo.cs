using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class ABM_Articulo
    {
        public FMRArticulo articulo;
        public List<FMRArticulo> list = new List<FMRArticulo>();

        //metodos
       public void Alta(FMRArticulo a)
        {
        list.Add(a);
        }
        
        public void Baja(int ID)
        {
        }

        public void Modificar(int ID) 
        {
        }
        public void Listar()
        {
        }
        public FMRArticulo Buscar(string nombre)
        { 
            //consulta query

            FMRArticulo a= new FMRArticulo();
            //a=repuesta query

            return a;
        } 

       


    }



}
