using Desafio_Bodega_Eva.Modelos;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Representa un nodo del Árbol Binario de Búsqueda de boletas.
    // Cada nodo almacena una boleta y referencias a sus hijos izquierdo y derecho.
    internal class NodoArbol
    {
        public string Clave { get; set; }
        public Boleta Dato { get; set; }

        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        // Constructor del nodo.
        public NodoArbol(string clave, Boleta dato)
        {
            Clave = clave;
            Dato = dato;
            Izquierdo = null;
            Derecho = null;
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo define el nodo utilizado por el Árbol Binario de Búsqueda
 * para almacenar las boletas registradas en Bodega Eva.
 *
 * Cada NodoArbol contiene una clave asociada al código de la boleta,
 * el objeto Boleta que almacena toda su información y dos referencias
 * que permiten conectar el nodo con sus hijos izquierdo y derecho.
 *
 * La propiedad Izquierdo permite almacenar los códigos menores que la
 * clave del nodo actual, mientras que Derecho permite almacenar los
 * códigos mayores. Esta organización permite realizar búsquedas siguiendo
 * la estructura del árbol sin recorrer necesariamente todos los registros.
 *
 * El nodo será utilizado posteriormente por ArbolBoleta.cs para realizar
 * las operaciones de inserción, búsqueda y recorrido del árbol.
 *
 * Aporte: Usuario 2 - Implementación del nodo del Árbol Binario de Búsqueda.
 */