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
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if(producto.ID == 0)
            {
                producto.ID = ListaProductos.Max(item => item.ID) + 1;
            }
            resultado.Exitoso =true;
            return resultado;
        }
        public void AgregarProduto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }
        public bool EliminarProducto(int ID)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.ID == ID)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }
            return false;
        }
        private Resultado validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion)== true)
            {
                resultado.Mensaje = "ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "la existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio > 0)
            {
                resultado.Mensaje = "el precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;
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

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
