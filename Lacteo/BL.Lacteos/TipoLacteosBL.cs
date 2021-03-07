using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Lacteos
{
    public class TipoLacteosBL
    {
        Contexto _contexto;

        public BindingList<TipoLacteos> ListaTipoLacteos { get; set; }

        public TipoLacteosBL()

        {
            _contexto = new Contexto();
            ListaTipoLacteos = new BindingList<TipoLacteos>();


        }
        public BindingList<TipoLacteos> ObtenerProductos()
        {
            _contexto.TipoLacteos.Load();
            ListaTipoLacteos = _contexto.TipoLacteos.Local.ToBindingList();

            return ListaTipoLacteos;
        }
    }
    public class TipoLacteos
    {
        public int ID { get; set; }
        public string  Descripcion{ get; set; }
    }
}
