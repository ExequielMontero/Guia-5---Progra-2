using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Banco : Producto
    {
        public Banco(double precioBase, double largo) : base(precioBase, largo)
        {
        }

        public override double Peso()
        {
            return (Largo*025)*0.42;
        }

        public override double Precio()
        {
            return Peso() * PrecioBase * 1.45;
        }
    }
}
