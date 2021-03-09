using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Lacteos
{
    class CategoriasBL
    {
        Contexto _contexto;

        public BindingList<categoria> ListaCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListaCategorias = new BindingList<categoria>();
        }
        public BindingList<categoria> ObtenerCategorias()

        {
            _contexto.Categorias.Load();
            ListaCategorias = _contexto.Categorias.Local.ToBindingList();
            

            return ListaCategorias;
        }
    }

     public class Categoria
    {
         public int Id { get; set; }
        public string Descripcion { get; set; 
    }
}
