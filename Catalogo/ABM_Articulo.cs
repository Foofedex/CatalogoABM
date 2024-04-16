using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class ABM_Articulo
    {
        public FMRArticulo articulo;
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
        public string Buscar(string nombre)
        {








            //a=repuesta query
            /*
         select a.Codigo, a.Nombre,a.Descripcion,a.Precio, m.Descripcion, c.Descripcion,i.ImagenUrl  from ARTICULOS a
inner join marcas  m on  a.IdMarca= m.Id 
inner join categorias c on a.idcategoria=c.id
inner join IMAGENES i on a.id=i.IdArticulo 
where  a.Nombre like '%canoa%' or a.Descripcion like '%canoa%' or  m.Descripcion like '%canoa%' or c.Descripcion like '%canoa%';


            */



            return nombre;
        } 

       


    }



}
