using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.COMMON;

namespace Principal
{
    public class RepositorioDeProductos
    {
        ManejadorDeArchivos archivoProductos;
        List<Producto> producto;
        public RepositorioDeProductos()
        {
            archivoProductos = new ManejadorDeArchivos("Productos.BD");
            producto = new List<Producto>();
        }
        public bool AgregarProducto(Producto product)
        {
            producto.Add(product);
            bool resultado = ActualizarArchivo();
            producto = leerProducto();
            return resultado;
        }
        public bool EliminarProducto(Producto product)
        {
            Producto temp = new Producto();
            foreach (var item in producto)
            {
                if (item.categoria == product.categoria)
                {
                    temp = item;
                }
            }
            producto.Remove(temp);
            bool resultado = ActualizarArchivo();
            producto = leerProducto();
            return resultado;
        } 
        public bool ModificarProducto(Producto original, Producto modificado)
        {
            Producto temp = new Producto();
            foreach (var item in producto)
            {
                if (original.categoria == item.categoria)
                {
                    temp = item;
                }
            }
            temp.cantidad = modificado.cantidad;
            temp.categoria = modificado.categoria;
            temp.descripcion = modificado.descripcion;
            temp.nombreDelProducto = modificado.nombreDelProducto;
            temp.PrecioCompra = modificado.PrecioCompra;
            temp.PrecioVenta = modificado.PrecioVenta;
            temp.presentacion = modificado.presentacion;

            bool resultado = ActualizarArchivo();
            producto = leerProducto();
            return resultado;
        }
        public bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Producto item in producto)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}\n",item.cantidad,item.categoria,item.descripcion,item.nombreDelProducto,item.PrecioCompra,item.PrecioVenta,item.presentacion);
            }
            return archivoProductos.Guardar(datos);
        }
        public List<Producto> leerProducto()
        {
            string datos = archivoProductos.Leer();
            if (datos != null)
            {
                List<Producto> produc = new List<Producto>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length-1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Producto produ = new Producto()
                    {
                        cantidad = int.Parse(campos[0]),
                        categoria = campos[1],
                        descripcion = campos[2],
                        nombreDelProducto = campos[3],
                        PrecioCompra = float.Parse(campos[4]),
                        PrecioVenta = float.Parse(campos[5]),
                        presentacion = campos[6]
                    };
                    produc.Add(produ);
                }
                producto = produc;
                return produc;
            }
            else
            {
                return null;
            }
        }
    }
}
