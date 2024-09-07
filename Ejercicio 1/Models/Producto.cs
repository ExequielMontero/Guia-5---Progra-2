using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal abstract class Producto:IComparable
    {
        public double PrecioBase { get; private set; }
        protected double Largo;

        protected Producto(double precioBase, double largo)
        {
            PrecioBase = precioBase;
            Largo = largo;
        }


        public int Codigo { get; set; }

        abstract public double Peso();
        abstract public double Precio();

        public int CompareTo(object obj)
        {
            Producto producto = obj as Producto;
            if(producto != null)
            {
                return Codigo.CompareTo(producto.Codigo);
            }
            return 1;
        }
    }
}
