using System;
using System.Collections.Generic;
using System.Text;

namespace Domador_Jaula_Leones
{
    internal class Jaula
    {
        private Leon leon;
        private Jaula siguiente;
        private Jaula anterior;

        internal Leon Leon1 { get => leon; set => leon = value;  }
        internal Jaula Siguiente { get => siguiente; set => siguiente = value; }
        internal Jaula Anterior { get => anterior; set => anterior = value; }
    }
}
