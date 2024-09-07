using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Presupuesto
    {
        public double Precio { get; private set; }
        Cliente solicitante;
        ArrayList listaProducto = new ArrayList();

        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto producto)
        {
            listaProducto.Add(producto);
            Precio += producto.Precio();
        }

        public bool QuitarProducto(int codigo)
        {
            listaProducto.Sort();
            Banco b = new Banco(0, 0);
            b.Codigo = codigo;
            int idx = listaProducto.BinarySearch(b);
            
            if (idx >= 0)
            {
                listaProducto.RemoveAt(idx);
            }
            return false;
        }

        public Producto BuscarProducto(int codigo)
        {
            listaProducto.Sort();
            Banco b = new Banco(0, 0);
            b.Codigo = codigo;
            int idx = listaProducto.BinarySearch(b);
            if (idx >= 0)
            {
                return listaProducto[idx] as Producto;
            }
            return null;
        }

        public string[] Resumen()
        {
            string[] text = new string[listaProducto.Count + 2];
            int n = 0;
            text[n++] = solicitante.ToString();
            foreach(Producto p in listaProducto)
            {
                text[n++] = $"-Codigo: {p.Codigo}, PrecioBase: {p.PrecioBase}, PrecioFinal: {p.Precio()}";
            }
            text[n++] = $"PrecioTotal:{Precio:f2}";

            return text;
        }
    }
}
