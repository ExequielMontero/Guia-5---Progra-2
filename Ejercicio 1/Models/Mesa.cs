using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Mesa:Producto
    {
        double Ancho;
        double Grosor;

        public Mesa(double precioBase, double largo, double Ancho, double Grosor) : base(precioBase, largo)
        {
            this.Ancho = Ancho;
            this.Grosor = Grosor;
        }
        public override double Precio()
        {
            return Peso() * PrecioBase * 1.25;
        }
        public override double Peso()
        {
            return (Largo * Ancho * Grosor) * 0.3;
        }
    }
}
