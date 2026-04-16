using System;
using System.Collections.Generic;
using System.Text;

namespace Domador_Jaula_Leones
{
    internal class Leon
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"{Nombre} con {Edad} año(s) de edad.";
        }
    }
}
