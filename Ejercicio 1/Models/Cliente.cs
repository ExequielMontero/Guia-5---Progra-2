using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Cliente
    {
        string Nombre;
        string Direccion;

        public Cliente(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Direccion: {Direccion}";
        }


    }
}
