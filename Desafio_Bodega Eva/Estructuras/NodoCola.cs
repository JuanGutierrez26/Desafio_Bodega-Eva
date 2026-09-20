using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Representa un nodo de la cola.
    // Cada nodo almacena un pedido y una referencia al siguiente pedido.
    public class NodoCola
    {
        public Pedido Dato { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Pedido dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
