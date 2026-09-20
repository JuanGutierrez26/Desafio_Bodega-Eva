using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Representa un nodo de la pila.
    // Cada nodo almacena una venta y una referencia a la siguiente venta.
    public class NodoPila
    {
        public Venta Dato { get; set; }
        public NodoPila Siguiente { get; set; }

        public NodoPila(Venta dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
