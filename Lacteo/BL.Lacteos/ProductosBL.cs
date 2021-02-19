using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Lacteos
{
    public class ProductosBL
    {
       public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()

        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.ID = 1;
            producto1.Descripcion = "Quezo semi seco";
            producto1.Precio = 28;
            producto1.Existencia = 20;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.ID = 2;
            producto2.Descripcion = "Mantequilla crema";
            producto2.Precio = 30;
            producto2.Existencia = 10;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.ID = 3;
            producto3.Descripcion = "Leche descremada";
            producto3.Precio = 50;
            producto3.Existencia =7;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4= new Producto();
            producto3.ID = 4;
            producto3.Descripcion = "Requezon";
            producto3.Precio = 50;
            producto3.Existencia = 10;
            producto3.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto3.ID = 5;
            producto3.Descripcion = "Quajada";
            producto3.Precio = 50;
            producto3.Existencia = 4;
            producto3.Activo = true;

            ListaProductos.Add(producto5);
        }
        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
        public bool GuardarProducto(Producto producto)
        {
            if(producto.ID == 0)
            {
                producto.ID = ListaProductos.Max(item => item.ID) + 1;
            }
            return true;
        }
        public void AgregarProduto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }
    }
    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }

    }
}
